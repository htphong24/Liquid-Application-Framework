﻿using FluentValidation;
using Liquid.Runtime.Configuration;

namespace Liquid.Repository
{
    public class MediaStorageConfiguration : LightConfig<MediaStorageConfiguration>
    {
        public string ConnectionString { get; set; }
        public string Container { get; set; }
        public string Permission { get; set; }

        public override void Validate()
        {
            RuleFor(d => ConnectionString).NotEmpty().WithMessage($"'{nameof(ConnectionString)}' on MediaStorage settings should not be empty.");
            RuleFor(d => Container).NotEmpty().WithMessage($"'{nameof(Container)}' on MediaStorage settings should not be empty.");
            RuleFor(d => Permission).NotEqual("Unknown").WithMessage("{PropertyName} on MediaStorage settings can't be Unknown");
        }
    }
}