using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockoutMvcWebApplication.Models
{
  public class QuoteEntryModel
  {
    public string InstantMessage { get; set; }

    public long SelectedInstrumentMappingId { get; set; }

    public List<NameId> AvailableInstrumentMappings { get; set; }

    public long SelectedBroker { get; set; }

    public List<NameId> AvailableBrokers { get; set; }

    public List<Leg> Legs { get; set; }

    public List<BidAskEntry> BidAskRow { get; set; }
  
    public class Leg
    {
      public int LegNo { get; set; }

      public int Ratio { get; set; }

      public string InstrumentName { get; set; }

      public string TermCodeName { get; set; }

      public double StrikePrice { get; set; }

      public bool Premium { get; set; }
    }

    public class BidAskEntry
    {
      public bool IsBidIOI { get; set; }

      public int BidQty { get; set; }

      public double BidPrice { get; set; }

      public double AskPrice { get; set; }

      public int AskQty { get; set; }

      public bool IsAskIOI { get; set; }
    }

    public class NameId
    {
      public string Name { get; set; }

      public long Id { get; set; }

      public NameId(string name, long id)
      {
        Name = name;
        Id = id;
      }
    }
  }
}