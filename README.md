# sampleMVC
Sitecore sample MVC project


With functional (but crude) looping proof of concept. The SampleController file will read in the guids.config file and push the guid to the SampleMvcInnerSublayout file. Then the SampleMvcInnerSublayout will loop through parentGuid, pulling in children guids and displaying content fields from the children guids(pages).

The parent guid is stored in a config file in app_config/include/zzz/Guids.config


The test page in sitecore for this test has 3 content fields, Headline, Introduction and Content. This however could be changed to any fields you want, as long as they are mirrored in the SampleMvcInnerSublayout. 



