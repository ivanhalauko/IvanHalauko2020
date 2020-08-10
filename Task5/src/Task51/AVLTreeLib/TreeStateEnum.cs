using System;
using System.Collections.Generic;
using System.Text;

namespace Task51.AVLTreeLib
{
    enum TreeStateEnum
    {
        Balanced, //Дерево сбалансировано
        LeftHeavy, //В левом поддереве больше элементов
        RightHeavy, //В правом поддереве больше элементов
    }
}
