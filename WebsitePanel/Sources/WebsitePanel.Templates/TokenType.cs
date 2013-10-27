// Copyright (c) 2012, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.Text;

namespace WebsitePanel.Templates
{
    internal enum TokenType
    {
        EOF,
        Text,

        Attribute, // tag attribute
        Identifier, // object.prop1.prop2

        // literals
        Integer,    // 1234
        Decimal,    // 12.34, 12,33
        String,     // "test\nstring with escapes and 'quotes' inside"
                    // 'single "quoted" string'
        Null,       // null
        Empty,      // empty
        True,       // true
        False,      // false

        // symbols
        LParen,		// (
        RParen,		// )
        LBracket,	// [
        RBracket,	// ]
        LBrace,     // {
        RBrace,     // }
        Colon,      // :
        Dot,        // .
        Comma,        // ,

        // operators
        Plus,       // +
        Minus,      // -
        Div,        // /
        Mult,       // *
        Mod,        // %
        BinOr,      // |
        BinAnd,     // &
        Or,         // ||, OR
        And,        // &&, AND
        Not,        // !, NOT
        Assign,      // =

        // comparisons
        Greater,    // >
        GreaterOrEqual, // >=
        Less,       // <
        LessOrEqual,// <=
        Equal,      // ==
        NotEqual,   // !=

        // start statements
        Set,        // {set}
        Template,   // {template}
        Print,      // {$ exp }
        If,         // {if exp}
        ElseIf,     // {elseif exp}
        Else,       // {else}
        Foreach,    // {foreach identifier in exp [index identifier]}
        For,        // {for identifier = exp to exp}

        // end statements
        EndTemplate,// {/template}
        EndIf,      // {/if}
        EndForeach, // {/foreach}
        EndFor,     // {/for}

        // custom tags
        OpenTag,    // <ad:Custom>
        CloseTag,   // </ad:Custom>
        EmptyTag    // .../>
    }
}
