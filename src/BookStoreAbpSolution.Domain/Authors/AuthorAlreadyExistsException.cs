﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace BookStoreAbpSolution.Authors;
public class AuthorAlreadyExistsException : BusinessException
{
    public AuthorAlreadyExistsException(string name)
        : base(BookStoreAbpSolutionDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}
