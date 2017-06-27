using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout
{
    public class GameButton : Button
    {
        public GameButton() : base()
        {
            this.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Size = new System.Drawing.Size(200, 50);
            this.UseVisualStyleBackColor = true;
        }
    }
}
