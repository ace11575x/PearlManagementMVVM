using PearlManagementMVVM.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearlManagementMVVM.ViewModels
{
  public class ProductViewModel : ObservableObject
  {
    private int reference;
    private string name;
    private string description;
    private string link;
    private bool isLot;
    private bool isSingle;
    private int minOrderQuantity;
    private double purchasePrice;
    private double sellPrice;

    public int Reference
    {
      get { return reference; }

      set
      {
        reference = value;
        RaisePropertyChangedEvent("Reference");
      }
    }
    public string Name
    {
      get { return name; }

      set
      {
        name = value;
        RaisePropertyChangedEvent("Name");
      }
    }
    public string Description
    {
      get { return description; }

      set
      {
        description = value;
        RaisePropertyChangedEvent("Description");
      }
    }
    public string Link
    {
      get { return link; }

      set
      {
        link = value;
        RaisePropertyChangedEvent("Link");
      }
    }
    public bool IsLot
    {
      get { return isLot; }

      set
      {
        isLot = value;
        RaisePropertyChangedEvent("IsLot");
      }
    }
    public bool IsSingle
    {
      get { return isSingle; }

      set
      {
        isSingle = value;
        RaisePropertyChangedEvent("IsSingle");
      }
    }
    public int MinOrderQuantity
    {
      get { return minOrderQuantity; }

      set
      {
        minOrderQuantity = value;
        RaisePropertyChangedEvent("MinOrderQuantity");
      }
    }
    public double PurchasePrice
    {
      get { return PurchasePrice; }

      set
      {
        purchasePrice = value;
        RaisePropertyChangedEvent("purchasePrice");
      }
    }
    public double SellPrice
    {
      get { return sellPrice; }

      set
      {
        sellPrice = value;
        RaisePropertyChangedEvent("SellPrice");
      }
    }


  }
}
