// File:    AffectedInstructor.cs
// Author:  zeine
// Created: lundi 8 avril 2024 10:09:49 AM
// Purpose: Definition of Class AffectedInstructor

using System;

public class AffectedInstructor
{
   public System.Collections.Generic.List<Path> path;
   
   /// <summary>
   /// Property for collection of Path
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Path> Path
   {
      get
      {
         if (path == null)
            path = new System.Collections.Generic.List<Path>();
         return path;
      }
      set
      {
         RemoveAllPath();
         if (value != null)
         {
            foreach (Path oPath in value)
               AddPath(oPath);
         }
      }
   }
   
   /// <summary>
   /// Add a new Path in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddPath(Path newPath)
   {
      if (newPath == null)
         return;
      if (this.path == null)
         this.path = new System.Collections.Generic.List<Path>();
      if (!this.path.Contains(newPath))
         this.path.Add(newPath);
   }
   
   /// <summary>
   /// Remove an existing Path from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemovePath(Path oldPath)
   {
      if (oldPath == null)
         return;
      if (this.path != null)
         if (this.path.Contains(oldPath))
            this.path.Remove(oldPath);
   }
   
   /// <summary>
   /// Remove all instances of Path from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllPath()
   {
      if (path != null)
         path.Clear();
   }

}