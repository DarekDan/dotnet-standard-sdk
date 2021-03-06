/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.SpeechToText.v1.Model
{
    /// <summary>
    /// SpeakerLabelsResult.
    /// </summary>
    public class SpeakerLabelsResult : BaseModel
    {
        /// <summary>
        /// The start time of a word from the transcript. The value matches the start time of a word from the `timestamps` array.
        /// </summary>
        /// <value>The start time of a word from the transcript. The value matches the start time of a word from the `timestamps` array.</value>
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public float? From { get; set; }
        /// <summary>
        /// The end time of a word from the transcript. The value matches the end time of a word from the `timestamps` array.
        /// </summary>
        /// <value>The end time of a word from the transcript. The value matches the end time of a word from the `timestamps` array.</value>
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public float? To { get; set; }
        /// <summary>
        /// The numeric identifier that the service assigns to a speaker from the audio. Speaker IDs begin at `0` initially but can evolve and change across interim results (if supported by the method) and between interim and final results as the service processes the audio. They are not guaranteed to be sequential, contiguous, or ordered.
        /// </summary>
        /// <value>The numeric identifier that the service assigns to a speaker from the audio. Speaker IDs begin at `0` initially but can evolve and change across interim results (if supported by the method) and between interim and final results as the service processes the audio. They are not guaranteed to be sequential, contiguous, or ordered.</value>
        [JsonProperty("speaker", NullValueHandling = NullValueHandling.Ignore)]
        public long? Speaker { get; set; }
        /// <summary>
        /// A score that indicates the service's confidence in its identification of the speaker in the range of 0 to 1.
        /// </summary>
        /// <value>A score that indicates the service's confidence in its identification of the speaker in the range of 0 to 1.</value>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public float? Confidence { get; set; }
        /// <summary>
        /// An indication of whether the service might further change word and speaker-label results. A value of `true` means that the service guarantees not to send any further updates for the current or any preceding results; `false` means that the service might send further updates to the results.
        /// </summary>
        /// <value>An indication of whether the service might further change word and speaker-label results. A value of `true` means that the service guarantees not to send any further updates for the current or any preceding results; `false` means that the service might send further updates to the results.</value>
        [JsonProperty("final", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FinalResults { get; set; }
    }

}
