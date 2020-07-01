using System;
using System.Collections.Generic;
using System.Text;

namespace IreneApp.Models
{
    public enum MenuItemType
    {
        SacolaAberta,
        SacolasFechadas, 
        VendaAtual
    }
    public class HomeMenuItem 
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
