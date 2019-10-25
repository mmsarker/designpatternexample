using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Ink;

namespace Mizan.Practice.Patterns.MomentoPattern
{
    public class InkCanvasWithUndo : InkCanvas
    {
        public IMomento CreateMomento()
        {
            Stroke[] copy = this.Strokes.ToArray();
            return new InkCanvasMomento { State = copy };
        }

        public void SetMomento(IMomento momento)
        {
            this.Strokes = new StrokeCollection((Stroke[])momento.State);
        }

        private class InkCanvasMomento : IMomento
        {
            public object State { get; set; }
        }
    }
}
