using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DTO
{
    public class WordReportDTO
    {
        public WordReportDTO(Dictionary<string, string> mergedFieList)
        {
            MergedFieldList = mergedFieList;
        }

        public Dictionary<string, string> MergedFieldList { get; set; }

        public void XuatReportWord(string pathSource, string pathOutput)
        {
            var dsThamso = this.MergedFieldList.ToList();
            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = pathSource;
            Application wordApp = new Application();
            Document wordDoc = new Document();
            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Field myMergeField in wordDoc.Fields)
            {
                Range rngFieldCode = myMergeField.Code;
                String fieldText = rngFieldCode.Text;
                // ONLY GETTING THE MAILMERGE FIELDS

                if (fieldText.StartsWith(" MERGEFIELD"))
                {

                    // THE TEXT COMES IN THE FORMAT OF

                    // MERGEFIELD  MyFieldName  \\* MERGEFORMAT

                    // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"

                    Int32 endMerge = fieldText.IndexOf("\\");

                    Int32 fieldNameLength = fieldText.Length - endMerge;

                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                    fieldName = fieldName.Trim();

                    // **** FIELD REPLACEMENT IMPLEMENTATION GOES HERE ****//

                    // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                    for (int i = 0; i < dsThamso.Count; i++)
                    {
                        if (fieldName.Equals(dsThamso[i].Key))
                        {
                            myMergeField.Select();
                            wordApp.Selection.TypeText(dsThamso[i].Value);
                            break;
                        }
                    }
                }
            }
            wordDoc.SaveAs(pathOutput);
            wordApp.Documents.Open(pathOutput);

        }


    }
}
