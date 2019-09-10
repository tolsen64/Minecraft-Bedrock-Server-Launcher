using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic;

namespace Minecraft_Server_Launcher
{
    public partial class Form1 : Form
    {
        private List<Permission> permissions;
        private List<Player> players;
        private List<Pack> packs;
        private EditObject editObject;
        private DataTable dt;
        private DataView dv;
        private string PlayerName;
        private string rxPlayerPattern = "Player (?<action>[disconetd]*?): (?<name>.*?), xuid: (?<xuid>.*)";
        private Regex rx;

        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("permission", typeof(string));
            dt.Columns.Add("whitelist", typeof(bool));
            dt.Columns.Add("ignorePlayerLimit", typeof(bool));
            dt.Columns.Add("xuid", typeof(string));
            dv = dt.DefaultView;
            dv.Sort = "name";
            gridPlayers.DataSource = dv;

            rx = new Regex(rxPlayerPattern);

            DirectoryInfo di = new DirectoryInfo("worlds");
            foreach (DirectoryInfo ddi in di.GetDirectories())
            {
                Debug.WriteLine(ddi.FullName);
                cboLevelName.Items.Add(ddi.Name);
            }

            using (StreamReader sr = new StreamReader("server.properties"))
            {
                while (sr.Peek() > 0)
                {
                    string s = sr.ReadLine();
                    if (s.Contains("="))
                    {
                        string[] ss = s.Split('=');
                        switch (ss[0])
                        {
                            case "server-name":
                                txtServerName.Text = ss[1];
                                break;
                            case "gamemode":
                                cboGameMode.SelectedItem = ss[1];
                                break;
                            case "difficulty":
                                cboDifficulty.SelectedItem = ss[1];
                                break;
                            case "allow-cheats":
                                chkAllowCheats.Checked = bool.Parse(ss[1]);
                                break;
                            case "max-players":
                                numMaxPlayers.Value = int.Parse(ss[1]);
                                break;
                            case "online-mode":
                                chkOnlineMode.Checked = bool.Parse(ss[1]);
                                break;
                            case "white-list":
                                chkUseWhitelist.Checked = bool.Parse(ss[1]);
                                break;
                            case "server-port":
                                numServerPort.Value = int.Parse(ss[1]);
                                break;
                            case "server-portv6":
                                numServerPortV6.Value = int.Parse(ss[1]);
                                break;
                            case "view-distance":
                                numViewDistance.Value = int.Parse(ss[1]);
                                break;
                            case "tick-distance":
                                numTickDistance.Value = int.Parse(ss[1]);
                                break;
                            case "player-idle-timeout":
                                numIdleTimeout.Value = int.Parse(ss[1]);
                                break;
                            case "max-threads":
                                numMaxThreads.Value = int.Parse(ss[1]);
                                break;
                            case "level-name":
                                cboLevelName.SelectedItem = ss[1];
                                break;
                            case "level-seed":
                                txtLevelSeed.Text = ss[1];
                                break;
                            case "default-player-permission-level":
                                cboPermission.SelectedItem = ss[1];
                                break;
                            case "texturepack-required":
                                chkTexturePackRequired.Checked = bool.Parse(ss[1]);
                                break;
                            case "content-log-file-enabled":
                                chkLogFileEnabled.Checked = bool.Parse(ss[1]);
                                break;
                            case "level-type":
                                cboLevelType.SelectedItem = ss[1];
                                break;
                        }
                    }
                }
                if (cboLevelType.SelectedIndex < 0)
                {
                    cboLevelType.SelectedIndex = 0;
                }
            }

            LoadPermissions();
            LoadWhitelist();
            LoadPacks();
        }

        private void LoadPermissions()
        {
            gridPermission.DataSource = typeof(Permission);
            permissions = JsonConvert.DeserializeObject<List<Permission>>(File.ReadAllText("permissions.json"));
            gridPermission.DataSource = permissions;
        }

        private void LoadWhitelist()
        {
            gridWhitelist.DataSource = typeof(Player);
            players = JsonConvert.DeserializeObject<List<Player>>(File.ReadAllText("whitelist.json"));
            gridWhitelist.DataSource = players;
        }

        private void LoadPacks()
        {
            gridPacks.DataSource = typeof(Pack);
            packs = JsonConvert.DeserializeObject<List<Pack>>(File.ReadAllText("valid_known_packs.json"));
            gridPacks.DataSource = packs;
        }

        private void ContextMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("MenuItemClick");
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            editObject.verb = mi.Text;
            switch (mi.Text)
            {
                case "Add":
                    editObject.permission = new Permission();
                    editObject.player = new Player();
                    editObject.pack = new Pack();
                    break;
                case "Remove":
                    switch (editObject.objType)
                    {
                        case "Permission":
                            gridPermission.DataSource = typeof(Permission);
                            permissions.Remove(editObject.permission);
                            gridPermission.DataSource = permissions;
                            break;
                        case "Whitelist":
                            gridWhitelist.DataSource = typeof(Player);
                            players.Remove(editObject.player);
                            gridWhitelist.DataSource = players;
                            break;
                        case "Packs":
                            gridPacks.DataSource = typeof(Pack);
                            packs.Remove(editObject.pack);
                            gridPacks.DataSource = packs;
                            break;
                    }
                    return;
            }
            using (dlgEdit dlg = new dlgEdit(editObject))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    editObject = dlg.editObject;
                    switch (editObject.objType)
                    {
                        case "Permission":
                            gridPermission.DataSource = typeof(Permission);
                            if (editObject.verb == "Edit")
                            {
                                permissions.RemoveAll(p => p.xuid == editObject.permission.xuid);
                            }
                            permissions.Add(editObject.permission);
                            gridPermission.DataSource = permissions;
                            break;
                        case "Whitelist":
                            gridWhitelist.DataSource = typeof(Player);
                            if (editObject.verb == "Edit")
                            {
                                players.RemoveAll(p => p.xuid == editObject.player.xuid);
                            }
                            players.Add(editObject.player);
                            gridWhitelist.DataSource = players;
                            break;
                        case "Packs":
                            gridPacks.DataSource = typeof(Pack);
                            if (editObject.verb == "Edit")
                            {
                                packs.RemoveAll(p => p.uuid == editObject.pack.uuid);
                            }
                            packs.Add(editObject.pack);
                            gridPacks.DataSource = packs;
                            break;
                    }
                }
            }
        }

        private void Grid_MouseDown(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("MouseClick");
            if (e.Button == MouseButtons.Right)
            {
                DataGridView grid = (DataGridView)sender;
                DataGridView.HitTestInfo hit = grid.HitTest(e.X, e.Y);
                string gridName = grid.Name.Replace("grid", "");
                editObject = new EditObject() { objType = gridName };
                editToolStripMenuItem.Visible = hit.RowIndex > -1;
                removeToolStripMenuItem.Visible = hit.RowIndex > -1;
                if (hit.RowIndex > -1)
                {
                    grid.Rows[hit.RowIndex].Selected = true;
                    switch (gridName)
                    {
                        case "Permission":
                            editObject.permission = (Permission)gridPermission.Rows[hit.RowIndex].DataBoundItem;
                            break;
                        case "Whitelist":
                            editObject.player = (Player)gridWhitelist.Rows[hit.RowIndex].DataBoundItem;
                            break;
                        case "Packs":
                            editObject.pack = (Pack)gridPacks.Rows[hit.RowIndex].DataBoundItem;
                            break;
                        case "Players":
                            PlayerName = gridPlayers.Rows[hit.RowIndex].Cells["name"].Value.ToString();
                            break;
                    }
                }
                else
                {
                    switch (gridName)
                    {
                        case "Permission":
                            editObject.permission = new Permission();
                            break;
                        case "Whitelist":
                            editObject.player = new Player();
                            break;
                        case "Packs":
                            editObject.pack = new Pack();
                            break;
                        case "Players":
                            PlayerName = "";
                            break;
                    }
                }
            }
        }

        private void BtnSaveConfig_Click(object sender, EventArgs e)
        {
            string txt = File.ReadAllText("server.properties");
            StringBuilder sb = new StringBuilder();
            using (StringReader sr = new StringReader(txt))
            {
                while (sr.Peek() > 0)
                {
                    string s = sr.ReadLine();
                    if (s.Contains("="))
                    {
                        string[] ss = s.Split('=');
                        switch (ss[0])
                        {
                            case "server-name":
                                ss[1] = txtServerName.Text;
                                break;
                            case "gamemode":
                                ss[1] = cboGameMode.SelectedItem.ToString();
                                break;
                            case "difficulty":
                                ss[1] = cboDifficulty.SelectedItem.ToString();
                                break;
                            case "allow-cheats":
                                ss[1] = chkAllowCheats.Checked.ToString().ToLower();
                                break;
                            case "max-players":
                                ss[1] = numMaxPlayers.Value.ToString();
                                break;
                            case "online-mode":
                                ss[1] = chkOnlineMode.Checked.ToString().ToLower();
                                break;
                            case "white-list":
                                ss[1] = chkUseWhitelist.Checked.ToString().ToLower();
                                break;
                            case "server-port":
                                ss[1] = numServerPort.Value.ToString();
                                break;
                            case "server-portv6":
                                ss[1] = numServerPortV6.Value.ToString();
                                break;
                            case "view-distance":
                                ss[1] = numViewDistance.Value.ToString();
                                break;
                            case "tick-distance":
                                ss[1] = numTickDistance.Value.ToString();
                                break;
                            case "player-idle-timeout":
                                ss[1] = numIdleTimeout.Value.ToString();
                                break;
                            case "max-threads":
                                ss[1] = numMaxThreads.Value.ToString();
                                break;
                            case "level-name":
                                ss[1] = cboLevelName.SelectedItem.ToString();
                                break;
                            case "level-seed":
                                ss[1] = txtLevelSeed.Text;
                                break;
                            case "default-player-permission-level":
                                ss[1] = cboPermission.SelectedItem.ToString();
                                break;
                            case "texturepack-required":
                                ss[1] = chkTexturePackRequired.Checked.ToString().ToLower();
                                break;
                            case "content-log-file-enabled":
                                ss[1] = chkLogFileEnabled.Checked.ToString().ToLower();
                                break;
                            case "level-type":
                                ss[1] = cboLevelType.SelectedItem.ToString();
                                break;
                        }
                        sb.AppendLine($"{ss[0]}={ss[1]}");
                    }
                    else
                    {
                        sb.AppendLine(s);
                    }
                }
            }
            if (!txt.Contains("level-type")) //this is not in the server.properties file as provied
            {
                sb.AppendLine($"level-type={cboLevelType.SelectedItem.ToString()}");
            }
            File.WriteAllText("server.properties", sb.ToString());
            SavePermissions();
            SavePacks();
            SaveWhitelist();
        }

        private void SavePermissions()
        {
            File.WriteAllText("permissions.json", JsonConvert.SerializeObject(permissions, Formatting.Indented));
        }

        private void SavePacks()
        {
            File.WriteAllText("valid_known_packs.json", JsonConvert.SerializeObject(packs, Formatting.Indented));
        }

        private void SaveWhitelist()
        {
            File.WriteAllText("whitelist.json", JsonConvert.SerializeObject(players, Formatting.Indented));
        }

        Server svr;

        private void BtnSaveAndStart_Click(object sender, EventArgs e)
        {
            BtnSaveConfig_Click(null, null);
            svr = new Server(WriteServerOutput);
        }

        private void BtnStopServer_Click(object sender, EventArgs e)
        {
            svr.SendCommand(Server.Commands.stop);
            svr = null;
        }

        private void WriteServerOutput(string txt)
        {
            txtServerOutput.BeginInvoke((Action)(() =>
            {
                txtServerOutput.AppendText($"{txt}\r\n");
                if (rx.IsMatch(txt))
                {
                    GroupCollection grp = rx.Match(txt).Groups;
                    if (grp["action"].Value == "disconnected")
                    {
                        dt.Rows.OfType<DataRow>()
                        .Where(r => r["xuid"].ToString() == grp["xuid"].Value)
                        .FirstOrDefault()
                        .Delete();
                        //.ToList()
                        //.ForEach(r => r.Delete());
                    }
                    else if (grp["action"].Value == "connected")
                    {
                        Permission pm = new Permission()
                        {
                            permission = cboPermission.SelectedItem.ToString(),
                            xuid = grp["xuid"].Value
                        };
                        if (!permissions.Any(perm => perm.xuid == pm.xuid))
                        {
                            permissions.Add(pm);
                            gridPermission.DataSource = typeof(Permission);
                            SavePermissions();
                            gridPermission.DataSource = permissions;
                        }
                        string p = permissions.FirstOrDefault(perm => perm.xuid == pm.xuid).permission;
                        bool w = players.Any(play => play.xuid == pm.xuid);
                        bool i = w ? players.FirstOrDefault(play => play.name == grp["name"].Value).ignoresPlayerLimit : false;
                        dt.Rows.Add(new object[] { grp["name"].Value, p, w, i, grp["xuid"].Value });
                    }
                }
                else if (txt.Contains("De-opped:") || txt.Contains("Opped:"))
                {
                    //De-opped: PhysicalBean119
                    //Opped: PhysicalBean119
                    // TODO: change permission in Players grid when opped or de-opped.
                    LoadPermissions();
                }
                else if (txt.Contains("whitelist"))
                {
                    LoadWhitelist();
                }
            }));
        }

        private void ContextMenuPlayers_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PlayerName))
            {
                Debug.WriteLine("Canceling");
                e.Cancel = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (svr != null)
            {
                svr.SendCommand(Server.Commands.stop);
                svr = null;
            }
        }

        private void OpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            svr.SendCommand(Server.Commands.op, PlayerName);
        }

        private void DeopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            svr.SendCommand(Server.Commands.deop, PlayerName);
        }

        private void KickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string KickReason = Interaction.InputBox("Reason:", $"Kick: {PlayerName}", "You have been kicked from the server.");
            svr.SendCommand(Server.Commands.kick, PlayerName, KickReason);
        }
    }
}
