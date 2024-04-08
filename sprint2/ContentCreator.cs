// File:    ContentCreator.cs
// Author:  zeine
// Created: lundi 8 avril 2024 11:01:04 AM
// Purpose: Definition of Class ContentCreator

using System;

public class ContentCreator : User
{
   private int attribut1;
   
   public void ManageContent()
   {
      throw new NotImplementedException();
   }
   
   public System.Collections.Generic.List<Challenge> challenge;
   
   /// <summary>
   /// Property for collection of Challenge
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Challenge> Challenge
   {
      get
      {
         if (challenge == null)
            challenge = new System.Collections.Generic.List<Challenge>();
         return challenge;
      }
      set
      {
         RemoveAllChallenge();
         if (value != null)
         {
            foreach (Challenge oChallenge in value)
               AddChallenge(oChallenge);
         }
      }
   }
   
   /// <summary>
   /// Add a new Challenge in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddChallenge(Challenge newChallenge)
   {
      if (newChallenge == null)
         return;
      if (this.challenge == null)
         this.challenge = new System.Collections.Generic.List<Challenge>();
      if (!this.challenge.Contains(newChallenge))
         this.challenge.Add(newChallenge);
   }
   
   /// <summary>
   /// Remove an existing Challenge from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveChallenge(Challenge oldChallenge)
   {
      if (oldChallenge == null)
         return;
      if (this.challenge != null)
         if (this.challenge.Contains(oldChallenge))
            this.challenge.Remove(oldChallenge);
   }
   
   /// <summary>
   /// Remove all instances of Challenge from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllChallenge()
   {
      if (challenge != null)
         challenge.Clear();
   }
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
   public System.Collections.Generic.List<SpecialQuiz> specialQuiz;
   
   /// <summary>
   /// Property for collection of SpecialQuiz
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<SpecialQuiz> SpecialQuiz
   {
      get
      {
         if (specialQuiz == null)
            specialQuiz = new System.Collections.Generic.List<SpecialQuiz>();
         return specialQuiz;
      }
      set
      {
         RemoveAllSpecialQuiz();
         if (value != null)
         {
            foreach (SpecialQuiz oSpecialQuiz in value)
               AddSpecialQuiz(oSpecialQuiz);
         }
      }
   }
   
   /// <summary>
   /// Add a new SpecialQuiz in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddSpecialQuiz(SpecialQuiz newSpecialQuiz)
   {
      if (newSpecialQuiz == null)
         return;
      if (this.specialQuiz == null)
         this.specialQuiz = new System.Collections.Generic.List<SpecialQuiz>();
      if (!this.specialQuiz.Contains(newSpecialQuiz))
         this.specialQuiz.Add(newSpecialQuiz);
   }
   
   /// <summary>
   /// Remove an existing SpecialQuiz from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveSpecialQuiz(SpecialQuiz oldSpecialQuiz)
   {
      if (oldSpecialQuiz == null)
         return;
      if (this.specialQuiz != null)
         if (this.specialQuiz.Contains(oldSpecialQuiz))
            this.specialQuiz.Remove(oldSpecialQuiz);
   }
   
   /// <summary>
   /// Remove all instances of SpecialQuiz from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllSpecialQuiz()
   {
      if (specialQuiz != null)
         specialQuiz.Clear();
   }

}