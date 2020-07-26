using Microsoft.Toolkit.Parsers.Markdown;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Markdown
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextFieldParser parser = new TextFieldParser(@"..\..\..\DbOperations.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                var buffer = new List<string[]>();
                while (!parser.EndOfData)
                {

                    var currentRow = parser.ReadFields();
                    buffer.Add(currentRow);

                }
                var toConvert = buffer[1][4];
                var list = toConvert.Split('\n');
                for (var line = 2; line < list.Count(); line++)
                {
                    var requirementBuffer = new Requirement();
                    var listCellsLine = list[line].Split('|');
                    requirementBuffer.APIProperty = listCellsLine[1];
                    requirementBuffer.Type = listCellsLine[2];
                    requirementBuffer.IsMandatory = (listCellsLine[3] == "required") ? true : false;
                    requirementBuffer.Description = listCellsLine[4];
                    Console.WriteLine(requirementBuffer.APIProperty);
                    Console.WriteLine(requirementBuffer.Type);
                    Console.WriteLine(requirementBuffer.IsMandatory);
                    Console.WriteLine(requirementBuffer.Description);

                }

            }
        }
    }
}
