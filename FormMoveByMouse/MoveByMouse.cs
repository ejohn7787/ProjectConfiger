using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMoveByMouse
{
    
    public class MoveByMouse
    {
        private Point MouseLeftButtonDownPoint;
        public void MouseLeftButtonDown(MouseEventArgs mouseEventArgs)
        {
            if(mouseEventArgs.Button == MouseButtons.Left)
            {
                //mouseEventArgs 得到鼠标在点击的窗体的相对于左上角的位置，记录下他的负值，得到偏移量
                MouseLeftButtonDownPoint = new Point(-mouseEventArgs.X,-mouseEventArgs.Y );
               
               
            }
           
        }
        public Point? MouseMove(MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                //得到鼠标相对于屏幕左上角的位置，如果没有偏移，则窗体会以左上角定位。即使你点击的不是左上角
                Point newPoint = Control.MousePosition;  
                //移动鼠标相对于窗体左上角的偏移值，修正位置。
                newPoint.Offset(MouseLeftButtonDownPoint.X, MouseLeftButtonDownPoint.Y);
                return newPoint;
               
                

            }
            else
            {
                return null;
            }
        }

    }
}
