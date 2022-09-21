﻿
using System;
using Contensive.Addons.AddonSamples.Controllers;
using Contensive.Addons.AddonSamples.Models.Db;
using Contensive.BaseClasses;
using Models.View;

namespace Contensive.Addons.AddonSamples {
    namespace Views {
        // 
        // ====================================================================================================
        /// <summary>
        ///     ''' Design block with a centered headline, image, paragraph text and a button.
        ///     ''' </summary>
        public class TileClass : AddonBaseClass {
            // 
            // ====================================================================================================
            // 
            public override object Execute(CPBaseClass CP) {
                const string designBlockName = "Tile Design Block";
                try {
                    // 
                    // -- read instanceId, guid created uniquely for this instance of the addon on a page
                    var result = string.Empty;
                    var settingsGuid = DesignBlockController.getSettingsGuid(CP, designBlockName, ref result);
                    if ((string.IsNullOrEmpty(settingsGuid)))
                        return result;
                    // 
                    // -- locate or create a data record for this guid
                    var settings = SampleSettingsModel.createOrAddSettings(CP, settingsGuid);
                    if ((settings == null))
                        throw new ApplicationException("Could not create the design block settings record.");
                    // 
                    // -- translate the Db model to a view model and mustache it into the layout
                    var viewModel = SampleViewModel.create(CP, settings);
                    if ((viewModel == null))
                        throw new ApplicationException("Could not create design block view model.");
                    result = Nustache.Core.Render.StringToString(AddonSamples.Properties.Resources.SampleLayout, viewModel);
                    // 
                    // -- if editing enabled, add the link and wrapperwrapper
                    return CP.Content.GetEditWrapper(result, SampleSettingsModel.tableMetadata.contentName, settings.id);
                } catch (Exception ex) {
                    CP.Site.ErrorReport(ex);
                    return "<!-- " + designBlockName + ", Unexpected Exception -->";
                }
            }
        }
    }
}