// File:    EnrolledNode.cs
// Author:  zeine
// Created: lundi 8 avril 2024 10:09:50 AM
// Purpose: Definition of Class EnrolledNode

using System;

public class EnrolledNode
{
   private String id;
   private Boolean isRated;
   
   public System.Collections.Generic.List<UserResponse> userResponse;
   
   /// <summary>
   /// Property for collection of UserResponse
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<UserResponse> UserResponse
   {
      get
      {
         if (userResponse == null)
            userResponse = new System.Collections.Generic.List<UserResponse>();
         return userResponse;
      }
      set
      {
         RemoveAllUserResponse();
         if (value != null)
         {
            foreach (UserResponse oUserResponse in value)
               AddUserResponse(oUserResponse);
         }
      }
   }
   
   /// <summary>
   /// Add a new UserResponse in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddUserResponse(UserResponse newUserResponse)
   {
      if (newUserResponse == null)
         return;
      if (this.userResponse == null)
         this.userResponse = new System.Collections.Generic.List<UserResponse>();
      if (!this.userResponse.Contains(newUserResponse))
         this.userResponse.Add(newUserResponse);
   }
   
   /// <summary>
   /// Remove an existing UserResponse from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveUserResponse(UserResponse oldUserResponse)
   {
      if (oldUserResponse == null)
         return;
      if (this.userResponse != null)
         if (this.userResponse.Contains(oldUserResponse))
            this.userResponse.Remove(oldUserResponse);
   }
   
   /// <summary>
   /// Remove all instances of UserResponse from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllUserResponse()
   {
      if (userResponse != null)
         userResponse.Clear();
   }

}