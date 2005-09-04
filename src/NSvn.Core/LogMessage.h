// $Id$
#pragma once
#include "stdafx.h"
#include "ChangedPathDictionary.h"
#include <svn_pools.h>
#include <svn_types.h>

namespace NSvn
{
    namespace Core
    {
        using namespace System;

        /// <summary>Represents a SVN log message.</summary>
        public __gc class LogMessage
        {
        public private:
            LogMessage( apr_hash_t* changedPaths, svn_revnum_t revision,
                const char* author, const char* date, const char* message,
                apr_pool_t* pool ) :
            revision( revision ),
                author( Utf8ToString(author, pool) ),
                date( ParseDate(date, pool) ),
                message( Utf8ToString(message, pool) )

            {
                if ( changedPaths != 0 )
                    this->changedPaths = 
                    ChangedPathDictionary::FromChangedPathsHash( changedPaths, pool );
                else
                    this->changedPaths = 0;
            }


        public:

            /// <summary>The paths changed in this revision.</summary>
            [System::Diagnostics::DebuggerStepThrough]
            __property ChangedPathDictionary* get_ChangedPaths()
            { return this->changedPaths; }

            /// <summary>The revision of this log message.</summary>
            [System::Diagnostics::DebuggerStepThrough]
            __property svn_revnum_t get_Revision()
            { return this->revision; }

            /// <summary>The author of this log message</summary>
            [System::Diagnostics::DebuggerStepThrough]
            __property String* get_Author()
            { return this->author; }

            /// <summary>The date this commit was made.</summary>
            [System::Diagnostics::DebuggerStepThrough]
            __property DateTime get_Date()
            { return this->date; }

            /// <summary>The actual log message</summary>
            [System::Diagnostics::DebuggerStepThrough]
            __property String* get_Message()
            { return this->message; }

        private:
            ChangedPathDictionary* changedPaths;
            svn_revnum_t revision;
            String* author;
            DateTime date;
            String* message;
        };
    }
}