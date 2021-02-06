using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Providers;

namespace MediaBrowser.Providers.Plugins.Tmdb.BoxSets
{
    /// <summary>
    /// External ID for a TMDB box set.
    /// </summary>
    public class TmdbBoxSetExternalId : IExternalId
    {
        /// <inheritdoc />
        public string ProviderName => TmdbUtils.ProviderName;

        /// <inheritdoc />
        public string Key => nameof(MetadataProvider.TmdbCollection);

        /// <inheritdoc />
        public ExternalIdMediaType? Type => ExternalIdMediaType.BoxSet;

        /// <inheritdoc />
        public string UrlFormatString => TmdbUtils.BaseTmdbUrl + "collection/{0}";

        /// <inheritdoc />
        public bool Supports(IHasProviderIds item)
        {
            return item is Movie || item is MusicVideo || item is Trailer;
        }
    }
}
