using System;
using System.Collections.Generic;
using System.Text;

namespace IreneApp.Models
{
    public enum MenuItemType
    {
        Sacolas,
        Sobre
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
