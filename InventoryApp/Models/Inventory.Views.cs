//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(InventoryApp.Models.InventoryContext),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets36280ce3da8278c964f14870a64011120038931c8d30606dbb77aa6e109e3fe1))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework Power Tools", "0.9.0.0")]
    internal sealed class ViewsForBaseEntitySets36280ce3da8278c964f14870a64011120038931c8d30606dbb77aa6e109e3fe1 : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "36280ce3da8278c964f14870a64011120038931c8d30606dbb77aa6e109e3fe1"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "InventoryContextStoreContainer.Categories")
            {
                return GetView0();
            }

            if (extentName == "InventoryContextStoreContainer.InventoryItems")
            {
                return GetView1();
            }

            if (extentName == "InventoryContextStoreContainer.Items")
            {
                return GetView2();
            }

            if (extentName == "InventoryContextStoreContainer.Locations")
            {
                return GetView3();
            }

            if (extentName == "InventoryContextStoreContainer.Status")
            {
                return GetView4();
            }

            if (extentName == "InventoryContextStoreContainer.Trackings")
            {
                return GetView5();
            }

            if (extentName == "InventoryContext.Categories")
            {
                return GetView6();
            }

            if (extentName == "InventoryContext.InventoryItems")
            {
                return GetView7();
            }

            if (extentName == "InventoryContext.Items")
            {
                return GetView8();
            }

            if (extentName == "InventoryContext.Locations")
            {
                return GetView9();
            }

            if (extentName == "InventoryContext.Status")
            {
                return GetView10();
            }

            if (extentName == "InventoryContext.Trackings")
            {
                return GetView11();
            }

            if (extentName == "InventoryContextStoreContainer.DellWarrantyInfo")
            {
                return GetView12();
            }

            if (extentName == "InventoryContext.DellWarrantyInfoes")
            {
                return GetView13();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for InventoryContextStoreContainer.Categories.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Categories
        [InventoryContext.Store.Categories](T1.Categories_Id, T1.Categories_Name, T1.Categories_Type, T1.Categories_IsActive)
    FROM (
        SELECT 
            T.Id AS Categories_Id, 
            T.Name AS Categories_Name, 
            T.Type AS Categories_Type, 
            T.IsActive AS Categories_IsActive, 
            True AS _from0
        FROM InventoryContext.Categories AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContextStoreContainer.InventoryItems.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing InventoryItems
        [InventoryContext.Store.InventoryItems](T1.InventoryItems_Id, T1.InventoryItems_Quantity, T1.InventoryItems_IsActive, T1.InventoryItems_Price, T1.InventoryItems_ItAssetNum, T1.InventoryItems_CompAssetNum, T1.InventoryItems_Serial1, T1.InventoryItems_Serial2, T1.InventoryItems_Description, T1.InventoryItems_DateAdded, T1.InventoryItems_DateModified, T1.InventoryItems_ItemId, T1.InventoryItems_LocationId, T1.InventoryItems_ModifiedBy)
    FROM (
        SELECT 
            T.Id AS InventoryItems_Id, 
            T.Quantity AS InventoryItems_Quantity, 
            T.IsActive AS InventoryItems_IsActive, 
            T.Price AS InventoryItems_Price, 
            T.ItAssetNum AS InventoryItems_ItAssetNum, 
            T.CompAssetNum AS InventoryItems_CompAssetNum, 
            T.Serial1 AS InventoryItems_Serial1, 
            T.Serial2 AS InventoryItems_Serial2, 
            T.Description AS InventoryItems_Description, 
            T.DateAdded AS InventoryItems_DateAdded, 
            T.DateModified AS InventoryItems_DateModified, 
            T.ItemId AS InventoryItems_ItemId, 
            T.LocationId AS InventoryItems_LocationId, 
            T.ModifiedBy AS InventoryItems_ModifiedBy, 
            True AS _from0
        FROM InventoryContext.InventoryItems AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContextStoreContainer.Items.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Items
        [InventoryContext.Store.Items](T1.Items_Id, T1.Items_Name, T1.Items_Description, T1.Items_IsActive, T1.Items_DateAdded, T1.Items_DateModified, T1.Items_CategoryId)
    FROM (
        SELECT 
            T.Id AS Items_Id, 
            T.Name AS Items_Name, 
            T.Description AS Items_Description, 
            T.IsActive AS Items_IsActive, 
            T.DateAdded AS Items_DateAdded, 
            T.DateModified AS Items_DateModified, 
            T.CategoryId AS Items_CategoryId, 
            True AS _from0
        FROM InventoryContext.Items AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContextStoreContainer.Locations.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Locations
        [InventoryContext.Store.Locations](T1.Locations_Id, T1.Locations_Name, T1.Locations_Description, T1.Locations_IsActive)
    FROM (
        SELECT 
            T.Id AS Locations_Id, 
            T.Name AS Locations_Name, 
            T.Description AS Locations_Description, 
            T.IsActive AS Locations_IsActive, 
            True AS _from0
        FROM InventoryContext.Locations AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContextStoreContainer.Status.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Status
        [InventoryContext.Store.Status](T1.Status_Id, T1.Status_Name, T1.Status_IsActive)
    FROM (
        SELECT 
            T.Id AS Status_Id, 
            T.Name AS Status_Name, 
            T.IsActive AS Status_IsActive, 
            True AS _from0
        FROM InventoryContext.Status AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContextStoreContainer.Trackings.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Trackings
        [InventoryContext.Store.Trackings](T1.Trackings_Id, T1.Trackings_JobNumber, T1.Trackings_User, T1.Trackings_StatusId, T1.Trackings_AddedBy, T1.Trackings_Date, T1.Trackings_Quantity, T1.Trackings_InventoryItemId)
    FROM (
        SELECT 
            T.Id AS Trackings_Id, 
            T.JobNumber AS Trackings_JobNumber, 
            T.User AS Trackings_User, 
            T.StatusId AS Trackings_StatusId, 
            T.AddedBy AS Trackings_AddedBy, 
            T.Date AS Trackings_Date, 
            T.Quantity AS Trackings_Quantity, 
            T.InventoryItemId AS Trackings_InventoryItemId, 
            True AS _from0
        FROM InventoryContext.Trackings AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContext.Categories.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView6()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Categories
        [Inventory.Category](T1.Category_Id, T1.Category_Name, T1.Category_Type, T1.Category_IsActive)
    FROM (
        SELECT 
            T.Id AS Category_Id, 
            T.Name AS Category_Name, 
            T.Type AS Category_Type, 
            T.IsActive AS Category_IsActive, 
            True AS _from0
        FROM InventoryContextStoreContainer.Categories AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContext.InventoryItems.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView7()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing InventoryItems
        [Inventory.InventoryItem](T1.InventoryItem_Id, T1.InventoryItem_Quantity, T1.InventoryItem_IsActive, T1.InventoryItem_Price, T1.InventoryItem_ItAssetNum, T1.InventoryItem_CompAssetNum, T1.InventoryItem_Serial1, T1.InventoryItem_Serial2, T1.InventoryItem_Description, T1.InventoryItem_DateAdded, T1.InventoryItem_DateModified, T1.InventoryItem_ItemId, T1.InventoryItem_LocationId, T1.InventoryItem_ModifiedBy)
    FROM (
        SELECT 
            T.Id AS InventoryItem_Id, 
            T.Quantity AS InventoryItem_Quantity, 
            T.IsActive AS InventoryItem_IsActive, 
            T.Price AS InventoryItem_Price, 
            T.ItAssetNum AS InventoryItem_ItAssetNum, 
            T.CompAssetNum AS InventoryItem_CompAssetNum, 
            T.Serial1 AS InventoryItem_Serial1, 
            T.Serial2 AS InventoryItem_Serial2, 
            T.Description AS InventoryItem_Description, 
            T.DateAdded AS InventoryItem_DateAdded, 
            T.DateModified AS InventoryItem_DateModified, 
            T.ItemId AS InventoryItem_ItemId, 
            T.LocationId AS InventoryItem_LocationId, 
            T.ModifiedBy AS InventoryItem_ModifiedBy, 
            True AS _from0
        FROM InventoryContextStoreContainer.InventoryItems AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContext.Items.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView8()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Items
        [Inventory.Item](T1.Item_Id, T1.Item_Name, T1.Item_Description, T1.Item_IsActive, T1.Item_DateAdded, T1.Item_DateModified, T1.Item_CategoryId)
    FROM (
        SELECT 
            T.Id AS Item_Id, 
            T.Name AS Item_Name, 
            T.Description AS Item_Description, 
            T.IsActive AS Item_IsActive, 
            T.DateAdded AS Item_DateAdded, 
            T.DateModified AS Item_DateModified, 
            T.CategoryId AS Item_CategoryId, 
            True AS _from0
        FROM InventoryContextStoreContainer.Items AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContext.Locations.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView9()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Locations
        [Inventory.Location](T1.Location_Id, T1.Location_Name, T1.Location_Description, T1.Location_IsActive)
    FROM (
        SELECT 
            T.Id AS Location_Id, 
            T.Name AS Location_Name, 
            T.Description AS Location_Description, 
            T.IsActive AS Location_IsActive, 
            True AS _from0
        FROM InventoryContextStoreContainer.Locations AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContext.Status.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView10()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Status
        [Inventory.Status](T1.Status_Id, T1.Status_Name, T1.Status_IsActive)
    FROM (
        SELECT 
            T.Id AS Status_Id, 
            T.Name AS Status_Name, 
            T.IsActive AS Status_IsActive, 
            True AS _from0
        FROM InventoryContextStoreContainer.Status AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContext.Trackings.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView11()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Trackings
        [Inventory.Tracking](T1.Tracking_Id, T1.Tracking_JobNumber, T1.Tracking_User, T1.Tracking_StatusId, T1.Tracking_AddedBy, T1.Tracking_Date, T1.Tracking_Quantity, T1.Tracking_InventoryItemId)
    FROM (
        SELECT 
            T.Id AS Tracking_Id, 
            T.JobNumber AS Tracking_JobNumber, 
            T.User AS Tracking_User, 
            T.StatusId AS Tracking_StatusId, 
            T.AddedBy AS Tracking_AddedBy, 
            T.Date AS Tracking_Date, 
            T.Quantity AS Tracking_Quantity, 
            T.InventoryItemId AS Tracking_InventoryItemId, 
            True AS _from0
        FROM InventoryContextStoreContainer.Trackings AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContextStoreContainer.DellWarrantyInfo.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView12()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing DellWarrantyInfo
        [InventoryContext.Store.DellWarrantyInfo](T1.DellWarrantyInfo_ID, T1.DellWarrantyInfo_ServiceTag, T1.DellWarrantyInfo_WarrantyProvider, T1.DellWarrantyInfo_WarrantyType, T1.DellWarrantyInfo_WarrantyEndDate)
    FROM (
        SELECT 
            T.ID AS DellWarrantyInfo_ID, 
            T.ServiceTag AS DellWarrantyInfo_ServiceTag, 
            T.WarrantyProvider AS DellWarrantyInfo_WarrantyProvider, 
            T.WarrantyType AS DellWarrantyInfo_WarrantyType, 
            T.WarrantyEndDate AS DellWarrantyInfo_WarrantyEndDate, 
            True AS _from0
        FROM InventoryContext.DellWarrantyInfoes AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for InventoryContext.DellWarrantyInfoes.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView13()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing DellWarrantyInfoes
        [Inventory.DellWarrantyInfo](T1.DellWarrantyInfo_ID, T1.DellWarrantyInfo_ServiceTag, T1.DellWarrantyInfo_WarrantyProvider, T1.DellWarrantyInfo_WarrantyType, T1.DellWarrantyInfo_WarrantyEndDate)
    FROM (
        SELECT 
            T.ID AS DellWarrantyInfo_ID, 
            T.ServiceTag AS DellWarrantyInfo_ServiceTag, 
            T.WarrantyProvider AS DellWarrantyInfo_WarrantyProvider, 
            T.WarrantyType AS DellWarrantyInfo_WarrantyType, 
            T.WarrantyEndDate AS DellWarrantyInfo_WarrantyEndDate, 
            True AS _from0
        FROM InventoryContextStoreContainer.DellWarrantyInfo AS T
    ) AS T1");
        }
    }
}