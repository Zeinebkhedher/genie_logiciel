// File:    Path.cs
// Author:  zeine
// Created: lundi 8 avril 2024 10:39:58 AM
// Purpose: Definition of Class Path

using System;

public class Path
{
   private String id;
   private String label;
   private String description;
   
   public System.Collections.Generic.List<Voucher> voucher;
   
   /// <summary>
   /// Property for collection of Voucher
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Voucher> Voucher
   {
      get
      {
         if (voucher == null)
            voucher = new System.Collections.Generic.List<Voucher>();
         return voucher;
      }
      set
      {
         RemoveAllVoucher();
         if (value != null)
         {
            foreach (Voucher oVoucher in value)
               AddVoucher(oVoucher);
         }
      }
   }
   
   /// <summary>
   /// Add a new Voucher in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddVoucher(Voucher newVoucher)
   {
      if (newVoucher == null)
         return;
      if (this.voucher == null)
         this.voucher = new System.Collections.Generic.List<Voucher>();
      if (!this.voucher.Contains(newVoucher))
         this.voucher.Add(newVoucher);
   }
   
   /// <summary>
   /// Remove an existing Voucher from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveVoucher(Voucher oldVoucher)
   {
      if (oldVoucher == null)
         return;
      if (this.voucher != null)
         if (this.voucher.Contains(oldVoucher))
            this.voucher.Remove(oldVoucher);
   }
   
   /// <summary>
   /// Remove all instances of Voucher from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllVoucher()
   {
      if (voucher != null)
         voucher.Clear();
   }

}