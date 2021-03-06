﻿/*
 * Piranha CMS
 * Copyright (c) 2014, Håkan Edling, All rights reserved.
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library.
 */

using System;
using System.Web;

namespace Piranha.Web.Mvc
{
	/// <summary>
	/// Static UI helper for ASP.NET MVC.
	/// </summary>
	public static class UI
	{
		#region Properties
		/// <summary>
		/// The private UIHelper.
		/// </summary>
		private static Web.Helpers.UIHelper helper = new Helpers.UIHelper();
		#endregion

		/// <summary>
		/// Gets the block with the given slug.
		/// </summary>
		/// <param name="slug">The unique slug</param>
		/// <returns>The block content</returns>
		public static IHtmlString Block(string slug) {
			return helper.Block(slug);
		}

		/// <summary>
		/// Renders the head meta data from the currently requested content.
		/// </summary>
		/// <returns>The meta data</returns>
		public static IHtmlString Head() {
			return helper.Head();
		}

		/// <summary>
		/// Renders the permalink for the given post.
		/// </summary>
		/// <param name="post">The post</param>
		/// <returns>The generated permalink</returns>
		public static IHtmlString Permalink(Models.PostModel post) {
			return helper.Permalink(post);
		}

		/// <summary>
		/// Renders the permalink for the given post.
		/// </summary>
		/// <param name="post">The post</param>
		/// <returns>The generated permalink</returns>
		public static IHtmlString Permalink(Piranha.Models.Post post) {
			return helper.Permalink(post);
		}

		/// <summary>
		/// Generates a gravatar url for the given email and size.
		/// </summary>
		/// <param name="email">The email address</param>
		/// <param name="size">The size in pixels</param>
		/// <returns>The gravatar url</returns>
		public static IHtmlString GravatarUrl(string email, int size) {
			return helper.GravatarUrl(email, size);
		}

		/// <summary>
		/// Renders the url to the given media file.
		/// </summary>
		/// <param name="media">The media file</param>
		/// <returns>The url</returns>
		public static IHtmlString Media(Piranha.Models.Media media, int? width, int? height) {
			return helper.Media(media, width, height);
		}

		/// <summary>
		/// Renders the thumbnail url to the given media file.
		/// </summary>
		/// <param name="media">The media file</param>
		/// <returns>The url</returns>
		public static IHtmlString Thumbnail(Piranha.Models.Media media, int? size) {
			return helper.Thumbnail(media, size);
		}

		/// <summary>
		/// Return the site structure as an ul/li list with the current page selected.
		/// </summary>
		/// <param name="start">The start level of the menu</param>
		/// <param name="stop">The stop level of the menu</param>
		/// <param name="levels">The number of levels. Use this if you don't know the start level</param>
		/// <param name="root">Optional rootnode for the menu to start from</param>
		/// <param name="css">Optional css class for the outermost container</param>
		/// <returns>A rendered menu</returns>
		public static IHtmlString Menu(int start = 1, int stop = Int32.MaxValue, int levels = 0, string root = "", string css = "menu") {
			return helper.Menu(start, stop, levels, root, css);
		}
	}
}
