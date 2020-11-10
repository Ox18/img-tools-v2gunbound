﻿/*  ----------------------------------------------------------------------------
 *  Copyright (C) 2011 XfsGames <http://www.xfsgames.com.ar/>
 *  ----------------------------------------------------------------------------
 *  Img Tools
 *  ----------------------------------------------------------------------------
 *  File:       FileNode.cs
 *  Author:     CARLOSX
 *  ----------------------------------------------------------------------------
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImgTools
{
    public class FileNode : TreeNode
    {

        private ArchivedFile m_ArchivedFile;
        private int m_Icon;

        public ArchivedFile ArchivedFile
        {
            get
            {
                return m_ArchivedFile;
            }
        }

        public int Icon
        {
            get
            {
                return m_Icon;
            }
        }

        public FileNode(ArchivedFile archivedFile, int icon)
            : base(archivedFile.FileName)
        {
            ImageIndex = 2 + (icon * 2);
            SelectedImageIndex = 3 + (icon * 2);
            m_ArchivedFile = archivedFile;
            m_Icon = icon;
        }

    } // class FileNode

}