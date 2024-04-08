// File:    Student.cs
// Author:  zeine
// Created: lundi 8 avril 2024 11:10:48 AM
// Purpose: Definition of Class Student

using System;

public class Student : User
{
   public void ManageChatRoom()
   {
      throw new NotImplementedException();
   }
   
   public void ConsultStatistics()
   {
      throw new NotImplementedException();
   }
   
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
   public System.Collections.Generic.List<Room> room;
   
   /// <summary>
   /// Property for collection of Room
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Room> Room
   {
      get
      {
         if (room == null)
            room = new System.Collections.Generic.List<Room>();
         return room;
      }
      set
      {
         RemoveAllRoom();
         if (value != null)
         {
            foreach (Room oRoom in value)
               AddRoom(oRoom);
         }
      }
   }
   
   /// <summary>
   /// Add a new Room in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddRoom(Room newRoom)
   {
      if (newRoom == null)
         return;
      if (this.room == null)
         this.room = new System.Collections.Generic.List<Room>();
      if (!this.room.Contains(newRoom))
         this.room.Add(newRoom);
   }
   
   /// <summary>
   /// Remove an existing Room from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveRoom(Room oldRoom)
   {
      if (oldRoom == null)
         return;
      if (this.room != null)
         if (this.room.Contains(oldRoom))
            this.room.Remove(oldRoom);
   }
   
   /// <summary>
   /// Remove all instances of Room from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllRoom()
   {
      if (room != null)
         room.Clear();
   }

}