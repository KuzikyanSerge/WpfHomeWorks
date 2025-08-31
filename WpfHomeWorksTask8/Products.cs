using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfHomeWorksTask8
{
    public enum TipTovara
    {
        Еда,
        Бытовая_техника
    }
    public class Products
    {
        public string imya {  get; set; }
        public int tsena {  get; set; }
        public string? izobradzenie {  get; set; }
        public TipTovara tipTovara {  get; set; }
    }
}
