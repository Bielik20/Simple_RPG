using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout
{
    
    public class BackgroundPanel : Panel
    {
        public BackgroundPanel() : base()
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            Dock = DockStyle.Fill;
        }
    }
}
