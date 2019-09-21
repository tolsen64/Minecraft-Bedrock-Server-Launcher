using System;
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
                    txtPermissionName.Text = editObject.permission.name;
                    cboPermission.SelectedItem = editObject.permission.permission;
                    txtPermissionXUID.Text = editObject.permission.xuid;
                    break;
                case "Whitelist":
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
            switch (editObject.objType)
            {
                case "Permission":
                    editObject.permission.name = txtPermissionName.Text;
                    editObject.permission.permission = (string)cboPermission.SelectedItem;
                    editObject.permission.xuid = txtPermissionXUID.Text;
                    break;
                case "Whitelist":
                    editObject.player.xuid = txtPlayerXUID.Text;
                    editObject.player.name = txtPlayerName.Text;
                    editObject.player.ignoresPlayerLimit = chkPlayerIgnorePlayerLimit.Checked;
                    break;
                case "Packs":
                    editObject.pack.file_system = txtPackFileSystem.Text;
                    editObject.pack.file_version = txtPackFileVersion.Text;
                    editObject.pack.path = txtPackPath.Text;
                    editObject.pack.uuid = txtPackUUID.Text;
                    editObject.pack.version = txtPackVersion.Text;
                    break;
            }
        }
    }
}
