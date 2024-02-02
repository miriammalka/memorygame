using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGameSystem
{
    public class Card: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        
        string _cardvalue = "";
        System.Drawing.Color _cardforecolor;
        System.Drawing.Color _cardbackcolor;

        public bool cardenabled { get; set; } = false;

        public string CardValue { 
            get => _cardvalue; 
            set 
            {
                _cardvalue = value;
                this.InvokePropertyChanged();
                
            } 
        }

    
        public System.Drawing.Color cardforecolor { get => _cardforecolor;
            set 
            { 
                _cardforecolor = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("CardForeColorMaui");
            } 
        }

        public System.Drawing.Color cardbackcolor { get=> _cardbackcolor;
            set 
            {
                _cardbackcolor = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("CardBackColorMaui");
            } 
        }

        public Microsoft.Maui.Graphics.Color CardBackColorMaui
        {
            get => this.ConvertToMauiColor(this.cardbackcolor);
        }

        public Microsoft.Maui.Graphics.Color CardForeColorMaui
        {
            get => this.ConvertToMauiColor(this.cardforecolor);
        }

        private Microsoft.Maui.Graphics.Color ConvertToMauiColor(System.Drawing.Color systemColor)
        {
            float red = systemColor.R / 255f;
            float green = systemColor.G / 255f;
            float blue = systemColor.B / 255f;
            float alpha = systemColor.A / 255f;

            return new Microsoft.Maui.Graphics.Color(red, green, blue, alpha);
        }

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
