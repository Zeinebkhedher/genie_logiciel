// File:    Message.cs
// Author:  zeine
// Created: lundi 8 avril 2024 11:12:25 AM
// Purpose: Definition of Class Message

using System;

public class Message
{
   private String id;
   private String message;
   private Boolean isPinned;
   
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