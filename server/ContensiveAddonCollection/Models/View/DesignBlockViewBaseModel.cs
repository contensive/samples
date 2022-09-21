﻿
using System;
using Contensive.Addons.AddonSamples.Controllers;
using Contensive.Addons.AddonSamples.Models.Db;
using Contensive.BaseClasses;
using Contensive.Models.Db;

namespace Contensive.Addons.AddonSamples {
    namespace Models.View {
        public class DesignBlockViewBaseModel {
            public string styleBackgroundImage { get; set; }
            public string styleheight { get; set; }
            public string contentContainerClass { get; set; }
            public string outerContainerClass { get; set; }
            // 
            // ====================================================================================================
            /// <summary>
            ///         ''' Populate the view model from the entity model
            ///         ''' </summary>
            ///         ''' <param name="cp"></param>
            ///         ''' <param name="settings"></param>
            ///         ''' <returns></returns>
            public static T create<T>(CPBaseClass cp, Models.Db.DesignBlockBaseModel settings) where T : DesignBlockViewBaseModel {
                T result = null;
                try {
                    Type instanceType = typeof(T);
                    result = (T)Activator.CreateInstance(instanceType);
                    // 
                    // -- base fields
                    result.styleheight = encodeStyleHeight(settings.styleheight);
                    result.styleBackgroundImage = ""
                        + encodeStyleBackgroundImage(cp, settings.backgroundImageFilename)
                        + "";
                    result.outerContainerClass = ""
                        + (settings.themeStyleId.Equals(0) ? string.Empty : " ") + DbBaseModel.getRecordName<DesignBlockThemeModel>(cp, settings.themeStyleId)
                        + "";
                    result.contentContainerClass = ""
                        + (settings.asFullBleed ? " container" : string.Empty)
                        + (settings.padTop ? " pt-5" : " pt-0")
                        + (settings.padRight ? " pr-4" : " pr-0")
                        + (settings.padBottom ? " pb-5" : " pb-0")
                        + (settings.padLeft ? " pl-4" : " pl-0")
                        + "";
                } catch (Exception ex) {
                    cp.Site.ErrorReport(ex);
                }
                return result;
            }
            // 
            // ====================================================================================================
            /// <summary>
            ///         ''' convert string into a style "height: {styleHeight};", if value is numeric it adds "px"
            ///         ''' </summary>
            ///         ''' <param name="styleheight"></param>
            ///         ''' <returns></returns>
            public static string encodeStyleHeight(string styleheight) {
                return string.IsNullOrWhiteSpace(styleheight) ? string.Empty : "overflow:hidden;height:" + styleheight + (GenericController.isNumeric(styleheight) ? "px" : string.Empty) + ";";
            }
            // 
            // ====================================================================================================
            /// <summary>
            ///         ''' convert string into a style "background-image: url(backgroundImage)
            ///         ''' </summary>
            ///         ''' <param name="backgroundImage"></param>
            ///         ''' <returns></returns>
            public static string encodeStyleBackgroundImage(CPBaseClass cp, string backgroundImage) {
                return string.IsNullOrWhiteSpace(backgroundImage) ? string.Empty : "background-image: url('" + cp.Site.FilePath + backgroundImage + "');";
            }
        }
    }
}