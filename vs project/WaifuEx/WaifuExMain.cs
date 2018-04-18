using System;
using System.Windows.Forms;
using PavoStudio.ExApi;

namespace WaifuEx
{
    public partial class WaifuExMain : Form
    {
        public WaifuExMain()
        {
            InitializeComponent();
        }

        private void ModelDisplayButton_Click(object sender, EventArgs e)
        {
            ModelEntity entity = new ModelEntity();
            entity.id = 1;
            entity.file = "F:\\WaifuEx\\Sakurasou\\mashiro\\ryoufuku.model.json";
            RemoteMessage.Send(Msg.SetModel, entity);
        }

        private void ModelHideButton_Click(object sender, EventArgs e)
        {
            RemoteMessage.Send(Msg.RemoveModel, 1);
        }
    }
}
