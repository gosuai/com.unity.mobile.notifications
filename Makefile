LIBSDIR=com.unity.mobile.notifications/Runtime/Android/libs

androidnotifications: project/androidnotifications/build/outputs/aar/androidnotifications-release.aar
	cp $< $(LIBSDIR)

sdk: ../ai.gosu.gdp.test/sdk/build/outputs/aar/sdk-release.aar
	cp $< $(LIBSDIR)

fcm: ../ai.gosu.gdp.test/fcm/build/outputs/aar/fcm-release.aar
	cp $< $(LIBSDIR)

copy: androidnotifications sdk fcm
