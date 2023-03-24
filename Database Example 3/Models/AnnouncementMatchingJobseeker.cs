using System;
using System.Collections.Generic;

namespace Database_Example_3.Models;

public partial class AnnouncementMatchingJobseeker
{
    public long AnnouncementMatchingJobseekerId { get; set; }

    public long? AnnouncementMatchingListId { get; set; }

    public long AnnouncementId { get; set; }

    public long JobseekerId { get; set; }

    public double CurrentPositionFinalScore { get; set; }

    public double BestPositionFinalScore { get; set; }

    public double BestPositionAgePenalty { get; set; }

    public double BestPositionKeywordScore { get; set; }

    public double CurrentCategoryFinalScore { get; set; }

    public double CurrentSubCategoryScore { get; set; }

    public double CurrentHeadCategoryScore { get; set; }

    public double BestCategoryFinalScore { get; set; }

    public double BestSubCategoryScore { get; set; }

    public double BestHeadCategoryScore { get; set; }

    public double CurrentAggregatedCategoryFinalScore { get; set; }

    public double CurrentAggregatedSubCategoryScore { get; set; }

    public double CurrentAggregatedHeadCategoryScore { get; set; }

    public double BestAggregatedCategoryFinalScore { get; set; }

    public double BestAggregatedSubCategoryScore { get; set; }

    public double BestAggregatedHeadCategoryScore { get; set; }

    public double LanguageFinalScore { get; set; }

    public double DrivingLicenseFinalScore { get; set; }

    public double LocationFinalScore { get; set; }

    public double ExperienceFinalScore { get; set; }

    public double ExperienceSubCategoryScore { get; set; }

    public double ExperienceHeadCategoryScore { get; set; }

    public double FinalScore { get; set; }

    public int StatusId { get; set; }

    public DateTime? LastStatusUpdateDate { get; set; }

    public long? LastStatusUpdateUserId { get; set; }

    public double PositionFinalScore { get; set; }

    public double CategoryFinalScore { get; set; }

    public double MandatoryLanguageScore { get; set; }

    public double OptionalLanguageScore { get; set; }
}
