// File:    Challenge.cs
// Author:  zeine
// Created: lundi 8 avril 2024 10:26:42 AM
// Purpose: Definition of Class Challenge

using System;

public class Challenge
{
   private String id;
   private String description;
   private String contentLink;
   private String assetsLink;
   private String coverPictureLink;
   private Array tags;
   private Double requiredScore;
   
   public System.Collections.Generic.List<EnrolledChallenge> enrolledChallenge;
   
   /// <summary>
   /// Property for collection of EnrolledChallenge
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<EnrolledChallenge> EnrolledChallenge
   {
      get
      {
         if (enrolledChallenge == null)
            enrolledChallenge = new System.Collections.Generic.List<EnrolledChallenge>();
         return enrolledChallenge;
      }
      set
      {
         RemoveAllEnrolledChallenge();
         if (value != null)
         {
            foreach (EnrolledChallenge oEnrolledChallenge in value)
               AddEnrolledChallenge(oEnrolledChallenge);
         }
      }
   }
   
   /// <summary>
   /// Add a new EnrolledChallenge in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddEnrolledChallenge(EnrolledChallenge newEnrolledChallenge)
   {
      if (newEnrolledChallenge == null)
         return;
      if (this.enrolledChallenge == null)
         this.enrolledChallenge = new System.Collections.Generic.List<EnrolledChallenge>();
      if (!this.enrolledChallenge.Contains(newEnrolledChallenge))
         this.enrolledChallenge.Add(newEnrolledChallenge);
   }
   
   /// <summary>
   /// Remove an existing EnrolledChallenge from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveEnrolledChallenge(EnrolledChallenge oldEnrolledChallenge)
   {
      if (oldEnrolledChallenge == null)
         return;
      if (this.enrolledChallenge != null)
         if (this.enrolledChallenge.Contains(oldEnrolledChallenge))
            this.enrolledChallenge.Remove(oldEnrolledChallenge);
   }
   
   /// <summary>
   /// Remove all instances of EnrolledChallenge from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllEnrolledChallenge()
   {
      if (enrolledChallenge != null)
         enrolledChallenge.Clear();
   }

}