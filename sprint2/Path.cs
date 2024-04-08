// File:    Path.cs
// Author:  zeine
// Created: lundi 8 avril 2024 10:56:53 AM
// Purpose: Definition of Class Path

using System;

public class Path
{
   private String id;
   private String label;
   private String description;
   
   public Object CreatePath()
   {
      throw new NotImplementedException();
   }
   
   public Object UpdatePath()
   {
      throw new NotImplementedException();
   }
   
   public Object DeletePath()
   {
      throw new NotImplementedException();
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