﻿/mob
	parent_type = /atom/movable

	var/client/client
	var/key
	var/ckey


	var/see_invisible = 0
	var/sight = 0 as opendream_unimplemented
	var/see_in_dark = 2 as opendream_unimplemented

	layer = MOB_LAYER

	proc/Login()
		client.statobj = src

	proc/Logout()
