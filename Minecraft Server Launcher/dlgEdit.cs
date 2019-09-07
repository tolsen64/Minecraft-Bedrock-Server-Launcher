using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Server_Launcher
{
    public partial class dlgEdit : Form
    {
        
        public EditObject editObject { get; private set; }

        public dlgEdit(EditObject editObject)
        {
            InitializeComponent();
            panelPack.Bounds = panelPermission.Bounds;
            panelPlayer.Bounds = panelPermission.Bounds;
            Width = panelPermission.Width + 50;
            this.editObject = editObject;
            switch (editObject.objType)
            {
                case "Permission":
                    panelPermission.BringToFront();
                    cboPermission.SelectedItem = editObject.permission.permission;
                    txtPermissionXUID.Text = editObject.permission.xuid;
                    break;
                case "Player":
                    panelPlayer.BringToFront();
                    txtPlayerXUID.Text = editObject.player.xuid;
                    txtPlayerName.Text = editObject.player.name;
                    chkPlayerIgnorePlayerLimit.Checked = editObject.player.ignoresPlayerLimit;
                    break;
                case "Packs":
                    panelPack.BringToFront();
                    txtPackFileSystem.Text = editObject.pack.file_system;
                    txtPackFileVersion.Text = editObject.pack.file_version;
                    txtPackPath.Text = editObject.pack.path;
                    txtPackUUID.Text = editObject.pack.uuid;
                    txtPackVersion.Text = editObject.pack.version;
                    break;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            editObject = null;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
