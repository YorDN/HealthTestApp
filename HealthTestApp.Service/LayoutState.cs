using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthTestApp.Service
{
    public class LayoutState
    {
        public string HeaderTitle { get; private set; } = string.Empty;
        public string Cathegory { get; private set; } = string.Empty;
        public string Color { get; private set; } = string.Empty;

        public event Action? OnChange;

        public void SetLayout(string header, string cathegory)
        {
            HeaderTitle = header;
            Cathegory = cathegory;
            OnChange?.Invoke();
        }
        public void SetCustomLayout(string header, string cathegory, string color)
        {
            HeaderTitle = header;
            Cathegory = cathegory;
            Color = color;
            OnChange?.Invoke();
        }
    }
}
