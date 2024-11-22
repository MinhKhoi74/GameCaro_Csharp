using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace Game_Caro
{
    public class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, Color textColor)
        {
         
            Text = "Message";

            
            Size = new Size(400, 150);

      
            StartPosition = FormStartPosition.CenterScreen;

            
            ControlBox = true;

            // Tạo một Label để hiển thị thông điệp
            Label label = new Label();
            label.Text = message;
            label.ForeColor = textColor;
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font("Mulish", 18, FontStyle.Bold);

            // Thêm Label vào Controls của cửa sổ
            Controls.Add(label);
        }

        private void InitializeComponent()
        {

        }
    }
}


