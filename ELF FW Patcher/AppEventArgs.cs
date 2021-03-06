﻿using System;

namespace ELF_FW_Patcher {
    /// <summary>
    /// Application Event Arguments.
    /// </summary>
    public class AppEventArgs : EventArgs {
        /// <summary>
        /// A string Message.
        /// </summary>
        public string Message;

        /// <summary>
        /// Determine that Data is Present or not.
        /// </summary>
        public bool DataPresent;

        /// <summary>
        /// Determine do Perform a Progress Bar step.
        /// </summary>
        public bool DoProgress;

        /// <summary>
        /// Application Event Arguments Instance Initializer.
        /// </summary>
        /// <param name="Message">The ApplicationEvent Message.</param>
        public AppEventArgs(string Message) { this.Message = Message; }

        /// <summary>
        /// Application Event Arguments Instance Initializer.
        /// </summary>
        /// <param name="DataPresent">The ApplicationEvent boolian.</param>
        public AppEventArgs(bool DataPresent) { this.DataPresent = DataPresent; }

        /// <summary>
        /// Application Event Arguments Instance Initializer.
        /// </summary>
        /// <param name="message">The ApplicationEvent Message.</param>
        /// <param name="progress">The Progress Step to do or not.</param>
        public AppEventArgs(string message, bool progress) { }
    }

    /// <summary>
    /// Application Event Arguments.
    /// </summary>
    public class SwissKnifeEventArgs : EventArgs {
        /// <summary>
        /// A count.
        /// </summary>
        public long Count;

        /// <summary>
        /// Instance initializer.
        /// </summary>
        /// <param name="count">A integer count.</param>
        public SwissKnifeEventArgs(long count) { Count = count; }
    }

    /// <summary>
    /// Exception Event Arguments.
    /// </summary>
    public class ExceptionEventArgs : EventArgs {
        /// <summary>
        /// The Exception Message.
        /// </summary>
        public string Message;

        /// <summary>
        /// Exception Event Arguments Instance Initializer.
        /// </summary>
        /// <param name="message">The Exception Message.</param>
        public ExceptionEventArgs(string message) { Message = message; }
    }
}
