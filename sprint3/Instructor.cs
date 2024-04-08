// File:    Instructor.cs
// Author:  zeine
// Created: lundi 8 avril 2024 10:09:47 AM
// Purpose: Definition of Class Instructor

using System;

public class Instructor : User
{
   public Double RateCheckpoints()
   {
      throw new NotImplementedException();
   }
   
   public Double RateProject()
   {
      throw new NotImplementedException();
   }
   
   public Double RateChallenge()
   {
      throw new NotImplementedException();
   }
   
   public System.Collections.Generic.List<AffectedInstructor> affectedInstructor;
   
   /// <summary>
   /// Property for collection of AffectedInstructor
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<AffectedInstructor> AffectedInstructor
   {
      get
      {
         if (affectedInstructor == null)
            affectedInstructor = new System.Collections.Generic.List<AffectedInstructor>();
         return affectedInstructor;
      }
      set
      {
         RemoveAllAffectedInstructor();
         if (value != null)
         {
            foreach (AffectedInstructor oAffectedInstructor in value)
               AddAffectedInstructor(oAffectedInstructor);
         }
      }
   }
   
   /// <summary>
   /// Add a new AffectedInstructor in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddAffectedInstructor(AffectedInstructor newAffectedInstructor)
   {
      if (newAffectedInstructor == null)
         return;
      if (this.affectedInstructor == null)
         this.affectedInstructor = new System.Collections.Generic.List<AffectedInstructor>();
      if (!this.affectedInstructor.Contains(newAffectedInstructor))
         this.affectedInstructor.Add(newAffectedInstructor);
   }
   
   /// <summary>
   /// Remove an existing AffectedInstructor from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveAffectedInstructor(AffectedInstructor oldAffectedInstructor)
   {
      if (oldAffectedInstructor == null)
         return;
      if (this.affectedInstructor != null)
         if (this.affectedInstructor.Contains(oldAffectedInstructor))
            this.affectedInstructor.Remove(oldAffectedInstructor);
   }
   
   /// <summary>
   /// Remove all instances of AffectedInstructor from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllAffectedInstructor()
   {
      if (affectedInstructor != null)
         affectedInstructor.Clear();
   }

}