﻿// ReSharper disable CheckNamespace
namespace IPA
{
    /// <summary>
    /// A generic interface for the modification for enhanced plugins.
    /// </summary>
    public interface IGenericEnhancedPlugin
    {
        /// <summary>
        /// Gets a list of executables this plugin should be executed on (without the file ending)
        /// </summary>
        /// <example>{ "PlayClub", "PlayClubStudio" }</example>
        string[] Filter { get; }

        /// <summary>
        /// Called after Update.
        /// </summary>
        void OnLateUpdate();
    }
}
