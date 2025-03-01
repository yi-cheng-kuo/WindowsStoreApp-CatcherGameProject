﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catcher.GameObjects
{
    /// <summary>
    /// 掉落物的Key值,用來判斷掉落物的類型與隨機產生時使用
    /// </summary>
    public enum DropObjectsKeyEnum
    {
        EMPTY = 0,
        PERSON_FAT_DANCE,
        PERSON_FLY_OLDLADY,
        PERSON_LITTLE_GIRL,
        PERSON_MAN_STUBBLE,
        PERSON_NAUGHTY_BOY,
        PERSON_OLD_MAN,
        PERSON_ROXANNE,

        //ITEM
        ITEM_BOOSTING_SHOES,
        ITEM_SLOW_SHOES,
    }
}
