using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModGuideConverter2.Core.DTOs.GerneralDTOs;

namespace ModGuideConverter2.Core.DTOs.MicrocredentialDTOs
{
    public class LearningSpecification
    {
        private List<TranslationText> _title;

        private TimeSpan _attendanceTime;

        private TimeSpan _selfStudyTime;

        public List<TranslationText> Title { get => _title; set => _title = value; }

        public TimeSpan AttendanceTime { get => _attendanceTime; set => _attendanceTime = value; }

        public TimeSpan SelfStudyTime { get => _selfStudyTime; set => _selfStudyTime = value; }

        public TimeSpan TotalWorkloadTime
        {
            get
            {
                TimeSpan timeSpan = TimeSpan.Zero;
                timeSpan.Add(_selfStudyTime);
                timeSpan.Add(_attendanceTime);
                return timeSpan;
            }
        }
    }
}
