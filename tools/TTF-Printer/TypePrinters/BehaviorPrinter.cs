﻿using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using log4net;
using System.Reflection;

namespace TTI.TTF.Taxonomy.TypePrinters
{
    internal static class BehaviorPrinter
    {
        private static readonly ILog _log;
        static BehaviorPrinter()
        {
            #region logging

            Utils.InitLog();
            _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            #endregion
        }

        public static void AddBehaviorProperties(WordprocessingDocument document, Model.Core.Behavior behavior)
        {
            _log.Info("Printing Behavior Properties: " + behavior.Artifact.Name);
            var body = document.MainDocumentPart.Document.Body;

            var aDef = body.AppendChild(new Paragraph());
            var adRun = aDef.AppendChild(new Run());
            adRun.AppendChild(new Text("Behavior Details"));
            Utils.ApplyStyleToParagraph(document, "Heading1", "Heading1", aDef, JustificationValues.Center);

            var basicProps = new[,]
            {
                {"Is External:", behavior.IsExternal.ToString()},
                {"Constructor:", behavior.ConstructorType}
            };
            Utils.AddTable(document, basicProps); //"PlainTable3"

            CommonPrinter.BuildInvocationsTable(document, behavior.Invocations);

            CommonPrinter.BuildPropertiesTable(document, behavior.Properties);

        }


        public static void AddBehaviorReferenceProperties(WordprocessingDocument document, Model.Core.BehaviorReference behavior)
        {
            _log.Info("Printing Behavior Properties: " + behavior.Reference.Id);
            var body = document.MainDocumentPart.Document.Body;

            var aDef = body.AppendChild(new Paragraph());
            var adRun = aDef.AppendChild(new Run());
            adRun.AppendChild(new Text("Behavior Reference"));
            Utils.ApplyStyleToParagraph(document, "Heading1", "Heading1", aDef, JustificationValues.Center);

            var rDef = body.AppendChild(new Paragraph());
            var rRun = rDef.AppendChild(new Run());
            rRun.AppendChild(new Text(behavior.Reference.ReferenceNotes));
            Utils.ApplyStyleToParagraph(document, "Normal", "Normal", rDef);

            var basicProps = new[,]
            {
                {"Is External:", behavior.IsExternal.ToString()},
                {"Constructor:", behavior.ConstructorType}
            };
            Utils.AddTable(document, basicProps); //"PlainTable3"


            var appDef = body.AppendChild(new Paragraph());
            var appRun = appDef.AppendChild(new Run());
            appRun.AppendChild(new Text("Applies To"));
            Utils.ApplyStyleToParagraph(document, "Heading2", "Heading2", appDef);
            foreach (var a in behavior.AppliesTo)
            {
                ArtifactPrinter.GenerateArtifactSymbol(document, a);
            }

            CommonPrinter.BuildInvocationsTable(document, behavior.Invocations);

            CommonPrinter.BuildInfluenceBindings(document, behavior.InfluenceBindings);
           
            CommonPrinter.BuildPropertiesTable(document, behavior.Properties);

        }
    }
}