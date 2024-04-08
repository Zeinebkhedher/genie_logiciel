// File:    SpecialQuiz.cs
// Author:  zeine
// Created: lundi 8 avril 2024 11:01:04 AM
// Purpose: Definition of Class SpecialQuiz

using System;

public class SpecialQuiz
{
   public void ManageSpecialQuiz()
   {
      throw new NotImplementedException();
   }
   
   public System.Collections.Generic.List<SuperSkill> superSkill;
   
   /// <summary>
   /// Property for collection of SuperSkill
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<SuperSkill> SuperSkill
   {
      get
      {
         if (superSkill == null)
            superSkill = new System.Collections.Generic.List<SuperSkill>();
         return superSkill;
      }
      set
      {
         RemoveAllSuperSkill();
         if (value != null)
         {
            foreach (SuperSkill oSuperSkill in value)
               AddSuperSkill(oSuperSkill);
         }
      }
   }
   
   /// <summary>
   /// Add a new SuperSkill in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddSuperSkill(SuperSkill newSuperSkill)
   {
      if (newSuperSkill == null)
         return;
      if (this.superSkill == null)
         this.superSkill = new System.Collections.Generic.List<SuperSkill>();
      if (!this.superSkill.Contains(newSuperSkill))
         this.superSkill.Add(newSuperSkill);
   }
   
   /// <summary>
   /// Remove an existing SuperSkill from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveSuperSkill(SuperSkill oldSuperSkill)
   {
      if (oldSuperSkill == null)
         return;
      if (this.superSkill != null)
         if (this.superSkill.Contains(oldSuperSkill))
            this.superSkill.Remove(oldSuperSkill);
   }
   
   /// <summary>
   /// Remove all instances of SuperSkill from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllSuperSkill()
   {
      if (superSkill != null)
         superSkill.Clear();
   }
   public System.Collections.Generic.List<Quiz> quiz;
   
   /// <summary>
   /// Property for collection of Quiz
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Quiz> Quiz
   {
      get
      {
         if (quiz == null)
            quiz = new System.Collections.Generic.List<Quiz>();
         return quiz;
      }
      set
      {
         RemoveAllQuiz();
         if (value != null)
         {
            foreach (Quiz oQuiz in value)
               AddQuiz(oQuiz);
         }
      }
   }
   
   /// <summary>
   /// Add a new Quiz in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddQuiz(Quiz newQuiz)
   {
      if (newQuiz == null)
         return;
      if (this.quiz == null)
         this.quiz = new System.Collections.Generic.List<Quiz>();
      if (!this.quiz.Contains(newQuiz))
         this.quiz.Add(newQuiz);
   }
   
   /// <summary>
   /// Remove an existing Quiz from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveQuiz(Quiz oldQuiz)
   {
      if (oldQuiz == null)
         return;
      if (this.quiz != null)
         if (this.quiz.Contains(oldQuiz))
            this.quiz.Remove(oldQuiz);
   }
   
   /// <summary>
   /// Remove all instances of Quiz from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllQuiz()
   {
      if (quiz != null)
         quiz.Clear();
   }

}