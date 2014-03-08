// Guids.cs
// MUST match guids.h
using System;

namespace Deloitte.DenizenScriptEditor
{
    static class GuidList
    {
        public const string guidDenizenScriptEditorPkgString = "612799ff-f2dd-4239-8fce-fdeb5c170f5e";
        public const string guidDenizenScriptEditorCmdSetString = "c1148342-6b39-4e2c-bbf0-4f44d56356b3";

        public static readonly Guid guidDenizenScriptEditorCmdSet = new Guid(guidDenizenScriptEditorCmdSetString);
    };
}