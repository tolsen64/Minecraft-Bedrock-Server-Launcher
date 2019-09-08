using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Minecraft_Server_Launcher
{
    public partial class Form1 : Form
    {
        private List<Permission> permissions;
        private List<Player> players;
        private List<Pack> packs;
        private EditObject editObject;

        public Form1()
        {
            InitializeComponent();
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
            }

            permissions = JsonConvert.DeserializeObject<List<Permission>>(File.ReadAllText("permissions.json"));
            gridPermission.DataSource = permissions;
            players = JsonConvert.DeserializeObject<List<Player>>(File.ReadAllText("whitelist.json"));
            gridWhitelist.DataSource = players;
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
                            permissions.Add(editObject.permission);
                            gridPermission.DataSource = permissions;
                            break;
                        case "Whitelist":
                            gridWhitelist.DataSource = typeof(Player);
                            players.Add(editObject.player);
                            gridWhitelist.DataSource = players;
                            break;
                        case "Packs":
                            gridPacks.DataSource = typeof(Pack);
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
                    }
                }
            }
        }
    }
}
