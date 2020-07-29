using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace my_library_for_cs
{
    /// <summary>
    /// 自己追跡クラス
    /// </summary>
    public class SelfTracking
    {
        /// <summary>
        /// 自分自身を知る
        /// <para>"クラス名.呼出元のメソッド名() "</para>
        /// </summary>
        public string WhoAmI(
            [CallerMemberName] string callerMemberName = "",
            [CallerFilePath] string callerFilePath = "",
            [CallerLineNumber] int callerLineNumber = 0,
            bool isMininum = true)
        {
            var iam = string.Empty;
            iam += this.GetType().Name + "." + callerMemberName + "() ";
            if (isMininum != true)
            {
                iam += callerFilePath + " ";
                iam += "[L:" + callerLineNumber + "] ";
            }
            return iam;
        }

        /// <summary>
        /// 今していることを知る
        /// </summary>
        public static string WhatAmIDoing()
        {
            return new StackFrame(1).GetMethod().Name + "() ";
        }
    }
}
