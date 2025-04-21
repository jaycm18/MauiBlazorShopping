using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorShopping.Models;

public class Shoplist
{
    public int Id { get; set; }
    public string Item { get; set; } = null!;
    public int Amount { get; set; }
    public bool Purchased { get; set; }
}
