// $Id$
//
// Copyright 2008 The AnkhSVN Project
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Ankh.UI.MergeWizard
{
    public partial class MergeBestPracticesPageControl : BasePageControl
    {
        public MergeBestPracticesPageControl()
        {
            InitializeComponent();
        }

        public void UpdateBestPracticeStatus(MergeBestPracticesPage.BestPractices bestPractice,
            bool passed)
        {
            PictureBox pBox;

            switch (bestPractice)
            {
                case MergeBestPracticesPage.BestPractices.NO_LOCAL_MODIFICATIONS:
                    pBox = noUncommitedModificationsPictureBox;
                    break;
                case MergeBestPracticesPage.BestPractices.NO_MIXED_REVISIONS:
                    pBox = singleRevisionPictureBox;
                    break;
                case MergeBestPracticesPage.BestPractices.NO_SWITCHED_CHILDREN:
                    pBox = noSwitchedChildrenPictureBox;
                    break;
                case MergeBestPracticesPage.BestPractices.COMPLETE_WORKING_COPY:
                    pBox = completeWorkingCopyPictureBox;
                    break;
                default:
                    pBox = null;
                    break;
            }

            if (pBox != null)
            {
                if (passed)
                    pBox.Image = MergeStrings.SuccessImage;
                else
                    pBox.Image = MergeStrings.ErrorImage;
            }
        }
    }
}
