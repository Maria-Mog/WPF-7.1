using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_7._1
{
    class MyCommands
    {
        public static RoutedCommand Unlock { get; set; }
        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.U, ModifierKeys.Alt, "Alt+U"));
            Unlock = new RoutedCommand("Открыть", typeof(MyCommands), inputs);
        }
            

    }
}
