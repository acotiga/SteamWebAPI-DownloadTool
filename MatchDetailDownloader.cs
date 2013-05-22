using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;

///
/// Author:     Alex Cotiga
/// Date:       May 20th, 2013
/// Filename:   MatchDetailDownloader.cs
///

namespace SteamAPI_MatchDetailDownloader
{
    class MatchDetailDownloader
    {

        //Steam API Match Detail Base URL
        private static string kURL = "https://api.steampowered.com/IDOTA2Match_570/GetMatchDetails/V001/?key=";

        //Steam API Format Tag for XML
        private static string kFormat = "&format=XML";

        //Steam API Match ID Tag
        private static string kMatchTag = "&match_id=";

        //List of Match IDs to request
        private List<string> mMatchIDList;

        public MatchDetailDownloader()
        {

        }

        /// <summary>
        /// MatchDetailDownloader will load a given Match History XML File, parse it for a list of Match IDs,
        /// then proceed to download individual Match Detail XML Files from Valve's server and save them
        /// in the given Output Directory as separate files labeled "MatchDetails_MatchID.xml".
        /// </summary>
        /// <param name="key">Steam API Developer Key</param>
        /// <param name="matchHistoryFilename">Location of Match History XML File</param>
        /// <param name="outputDirectory">Output Directory Folder</param>
        public void Download(string key, string matchHistoryFilename, string outputDirectory)
        {
            ParseCompleteMatchIDList(matchHistoryFilename);
            DownloadAllMatchDetails(key, outputDirectory);
        }

        /// <summary>
        /// Loads a Match History XML File from the given location and parses it for a list of Match IDs.
        /// </summary>
        /// <param name="matchHistoryFilename">Location of Match History XML File</param>
        private void ParseCompleteMatchIDList(string matchHistoryFilename)
        {
            XmlDocument document = new XmlDocument();
            document.Load(matchHistoryFilename);
            XmlElement root = document.DocumentElement;
            XmlNodeList nodeList = root.GetElementsByTagName("match_id");

            mMatchIDList = new List<string>(nodeList.Count);
            foreach (XmlNode n in nodeList)
            {
                mMatchIDList.Add(n.InnerText);
            }
        }

        /// <summary>
        /// Downloads all Match Detail XML Files from Valve's Server and saves them in individual files
        /// within the given Output Directory.
        /// </summary>
        /// <param name="key">Steam API Developer Key</param>
        /// <param name="outputDirectory">Output Directory</param>
        private void DownloadAllMatchDetails(string key, string outputDirectory)
        {
            foreach (string id in mMatchIDList)
            {
                //Downloads and saves the XML document as MatchDetails_<MatchID>.xml
                XmlDocument document = new XmlDocument();
                document.Load(kURL + key + kFormat + kMatchTag + id);
                document.Save(outputDirectory + "\\MatchDetails_" + id + ".xml");
                Thread.Sleep(1000); //Wait a full second before sending another request
            }
        }
    }
}
