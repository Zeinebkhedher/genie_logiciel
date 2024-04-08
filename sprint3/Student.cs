// File:    Student.cs
// Author:  zeine
// Created: lundi 8 avril 2024 10:09:49 AM
// Purpose: Definition of Class Student

using System;

public class Student : User
{
   public System.Collections.Generic.List<Statistics> statistics;
   
   /// <summary>
   /// Property for collection of Statistics
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Statistics> Statistics
   {
      get
      {
         if (statistics == null)
            statistics = new System.Collections.Generic.List<Statistics>();
         return statistics;
      }
      set
      {
         RemoveAllStatistics();
         if (value != null)
         {
            foreach (Statistics oStatistics in value)
               AddStatistics(oStatistics);
         }
      }
   }
   
   /// <summary>
   /// Add a new Statistics in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddStatistics(Statistics newStatistics)
   {
      if (newStatistics == null)
         return;
      if (this.statistics == null)
         this.statistics = new System.Collections.Generic.List<Statistics>();
      if (!this.statistics.Contains(newStatistics))
         this.statistics.Add(newStatistics);
   }
   
   /// <summary>
   /// Remove an existing Statistics from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveStatistics(Statistics oldStatistics)
   {
      if (oldStatistics == null)
         return;
      if (this.statistics != null)
         if (this.statistics.Contains(oldStatistics))
            this.statistics.Remove(oldStatistics);
   }
   
   /// <summary>
   /// Remove all instances of Statistics from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllStatistics()
   {
      if (statistics != null)
         statistics.Clear();
   }
   public System.Collections.Generic.List<EnrolledNode> enrolledNode;
   
   /// <summary>
   /// Property for collection of EnrolledNode
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<EnrolledNode> EnrolledNode
   {
      get
      {
         if (enrolledNode == null)
            enrolledNode = new System.Collections.Generic.List<EnrolledNode>();
         return enrolledNode;
      }
      set
      {
         RemoveAllEnrolledNode();
         if (value != null)
         {
            foreach (EnrolledNode oEnrolledNode in value)
               AddEnrolledNode(oEnrolledNode);
         }
      }
   }
   
   /// <summary>
   /// Add a new EnrolledNode in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddEnrolledNode(EnrolledNode newEnrolledNode)
   {
      if (newEnrolledNode == null)
         return;
      if (this.enrolledNode == null)
         this.enrolledNode = new System.Collections.Generic.List<EnrolledNode>();
      if (!this.enrolledNode.Contains(newEnrolledNode))
         this.enrolledNode.Add(newEnrolledNode);
   }
   
   /// <summary>
   /// Remove an existing EnrolledNode from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveEnrolledNode(EnrolledNode oldEnrolledNode)
   {
      if (oldEnrolledNode == null)
         return;
      if (this.enrolledNode != null)
         if (this.enrolledNode.Contains(oldEnrolledNode))
            this.enrolledNode.Remove(oldEnrolledNode);
   }
   
   /// <summary>
   /// Remove all instances of EnrolledNode from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllEnrolledNode()
   {
      if (enrolledNode != null)
         enrolledNode.Clear();
   }
   public System.Collections.Generic.List<EnrolledSpecialQuiz> enrolledSpecialQuiz;
   
   /// <summary>
   /// Property for collection of EnrolledSpecialQuiz
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<EnrolledSpecialQuiz> EnrolledSpecialQuiz
   {
      get
      {
         if (enrolledSpecialQuiz == null)
            enrolledSpecialQuiz = new System.Collections.Generic.List<EnrolledSpecialQuiz>();
         return enrolledSpecialQuiz;
      }
      set
      {
         RemoveAllEnrolledSpecialQuiz();
         if (value != null)
         {
            foreach (EnrolledSpecialQuiz oEnrolledSpecialQuiz in value)
               AddEnrolledSpecialQuiz(oEnrolledSpecialQuiz);
         }
      }
   }
   
   /// <summary>
   /// Add a new EnrolledSpecialQuiz in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddEnrolledSpecialQuiz(EnrolledSpecialQuiz newEnrolledSpecialQuiz)
   {
      if (newEnrolledSpecialQuiz == null)
         return;
      if (this.enrolledSpecialQuiz == null)
         this.enrolledSpecialQuiz = new System.Collections.Generic.List<EnrolledSpecialQuiz>();
      if (!this.enrolledSpecialQuiz.Contains(newEnrolledSpecialQuiz))
         this.enrolledSpecialQuiz.Add(newEnrolledSpecialQuiz);
   }
   
   /// <summary>
   /// Remove an existing EnrolledSpecialQuiz from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveEnrolledSpecialQuiz(EnrolledSpecialQuiz oldEnrolledSpecialQuiz)
   {
      if (oldEnrolledSpecialQuiz == null)
         return;
      if (this.enrolledSpecialQuiz != null)
         if (this.enrolledSpecialQuiz.Contains(oldEnrolledSpecialQuiz))
            this.enrolledSpecialQuiz.Remove(oldEnrolledSpecialQuiz);
   }
   
   /// <summary>
   /// Remove all instances of EnrolledSpecialQuiz from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllEnrolledSpecialQuiz()
   {
      if (enrolledSpecialQuiz != null)
         enrolledSpecialQuiz.Clear();
   }
   public EnrolledChallenge[] enrolledChallenge;
   public System.Collections.Generic.List<EnrolledPath> enrolledPath;
   
   /// <summary>
   /// Property for collection of EnrolledPath
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<EnrolledPath> EnrolledPath
   {
      get
      {
         if (enrolledPath == null)
            enrolledPath = new System.Collections.Generic.List<EnrolledPath>();
         return enrolledPath;
      }
      set
      {
         RemoveAllEnrolledPath();
         if (value != null)
         {
            foreach (EnrolledPath oEnrolledPath in value)
               AddEnrolledPath(oEnrolledPath);
         }
      }
   }
   
   /// <summary>
   /// Add a new EnrolledPath in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddEnrolledPath(EnrolledPath newEnrolledPath)
   {
      if (newEnrolledPath == null)
         return;
      if (this.enrolledPath == null)
         this.enrolledPath = new System.Collections.Generic.List<EnrolledPath>();
      if (!this.enrolledPath.Contains(newEnrolledPath))
         this.enrolledPath.Add(newEnrolledPath);
   }
   
   /// <summary>
   /// Remove an existing EnrolledPath from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveEnrolledPath(EnrolledPath oldEnrolledPath)
   {
      if (oldEnrolledPath == null)
         return;
      if (this.enrolledPath != null)
         if (this.enrolledPath.Contains(oldEnrolledPath))
            this.enrolledPath.Remove(oldEnrolledPath);
   }
   
   /// <summary>
   /// Remove all instances of EnrolledPath from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllEnrolledPath()
   {
      if (enrolledPath != null)
         enrolledPath.Clear();
   }

}