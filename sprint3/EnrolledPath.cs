// File:    EnrolledPath.cs
// Author:  zeine
// Created: lundi 8 avril 2024 10:09:48 AM
// Purpose: Definition of Class EnrolledPath

using System;

public class EnrolledPath
{
   private String id;
   private String score;
   
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
   public System.Collections.Generic.List<Node> node;
   
   /// <summary>
   /// Property for collection of Node
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Node> Node
   {
      get
      {
         if (node == null)
            node = new System.Collections.Generic.List<Node>();
         return node;
      }
      set
      {
         RemoveAllNode();
         if (value != null)
         {
            foreach (Node oNode in value)
               AddNode(oNode);
         }
      }
   }
   
   /// <summary>
   /// Add a new Node in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddNode(Node newNode)
   {
      if (newNode == null)
         return;
      if (this.node == null)
         this.node = new System.Collections.Generic.List<Node>();
      if (!this.node.Contains(newNode))
         this.node.Add(newNode);
   }
   
   /// <summary>
   /// Remove an existing Node from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveNode(Node oldNode)
   {
      if (oldNode == null)
         return;
      if (this.node != null)
         if (this.node.Contains(oldNode))
            this.node.Remove(oldNode);
   }
   
   /// <summary>
   /// Remove all instances of Node from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllNode()
   {
      if (node != null)
         node.Clear();
   }

}