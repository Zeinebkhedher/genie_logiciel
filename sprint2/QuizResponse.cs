// File:    QuizResponse.cs
// Author:  zeine
// Created: lundi 8 avril 2024 10:59:35 AM
// Purpose: Definition of Class QuizResponse

using System;

public class QuizResponse
{
   private String id;
   private String response;
   private Boolean status;
   
   public Array AddResponse()
   {
      throw new NotImplementedException();
   }
   
   public Array UpdateResponse()
   {
      throw new NotImplementedException();
   }
   
   public String DeleteResponse()
   {
      throw new NotImplementedException();
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