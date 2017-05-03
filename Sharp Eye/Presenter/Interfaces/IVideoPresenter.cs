﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Interfaces;

namespace Presenter.Interfaces
{
    interface IVideoPresenter
    {
        IVideoView GetView();
    }
}
