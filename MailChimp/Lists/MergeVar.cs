using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;

using ServiceStack.Text;

namespace MailChimp.Lists
{
    /// <summary>
    /// optional merges for the email (FNAME, LNAME, etc.) 
    /// Note that a merge field can only hold up to 255 bytes. Also, there are a few "special" keys
    /// </summary>
    [DataContract]
    public class MergeVar: IDictionary<string, object>
    {
        /// <summary>
        /// set this to change the email address. This is only respected on calls using update_existing or 
        /// when passed to listUpdateMember().
        /// </summary>
        [DataMember(Name = "new-email")]
        public string NewEmail
        {
            get;
            set;
        }

        /// <summary>
        /// Interest Groupings 
        /// </summary>
        [DataMember(Name = "groupings")]
        public List<Grouping> Groupings
        {
            get;
            set;
        }

        /// <summary>
        /// Set the Opt-in IP field. Abusing this may cause your account to 
        /// be suspended. We do validate this and it must not 
        /// be a private IP address.
        /// </summary>
        [DataMember(Name = "optin_ip")]
        public string OptInIP
        {
            get;
            set;
        }

        /// <summary>
        /// Set the Opt-in Time field. Abusing this may cause your account to be 
        /// suspended. We do validate this and it must be a valid date. 
        /// Use - 24 hour format in GMT, eg "2013-12-30 20:30:00" to be safe. 
        /// Generally, though, anything strtotime() understands we'll understand - http://us2.php.net/strtotime
        /// </summary>
        [DataMember(Name = "optin_time")]
        public string OptInTime
        {
            get;
            set;
        }

        /// <summary>
        /// Set the member's geographic location either by optin_ip or geo data.
        /// </summary>
        [DataMember(Name = "mc_location")]
        public MCLocation LocationData
        {
            get;
            set;
        }

        /// <summary>
        /// Set the member's language preference. Supported codes are fully 
        /// case-sensitive and can be found here: 
        /// http://kb.mailchimp.com/article/can-i-see-what-languages-my-subscribers-use#code
        /// </summary>
        [DataMember(Name = "mc_language")]
        public string Language
        {
            get;
            set;
        }

        /// <summary>
        /// List of notes
        /// </summary>
        [DataMember(Name = "mc_notes")]
        public List<MCNote> Notes
        {
            get;
            set;
        }

					private IDictionary<string, object> _local = new Dictionary<string, object>(StringComparer.CurrentCultureIgnoreCase);

		public void Add(string key, object value) {
			_local.Add(key, value);
		}

		public bool ContainsKey(string key) {
			return _local.ContainsKey(key);
		}

		public ICollection<string> Keys {
			get { return _local.Keys; }
		}

		public bool Remove(string key) {
			return _local.Remove(key);
		}

		public bool TryGetValue(string key, out object value) {
			return _local.TryGetValue(key, out value);
		}

		public ICollection<object> Values {
			get { return _local.Values; }
		}

		public object this[string key] {
			get {
				return _local[key];
			}
			set {
				_local[key] = value;
			}
		}

		public void Add(KeyValuePair<string, object> item) {
			_local.Add(item);
		}

		public void Clear() {
			_local.Clear();
		}

		public bool Contains(KeyValuePair<string, object> item) {
			return _local.Contains(item);
		}

		public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) {
			_local.CopyTo(array, arrayIndex);
		}

		public int Count {
			get { return _local.Count; }
		}

		public bool IsReadOnly {
			get { return _local.IsReadOnly; }
		}

		public bool Remove(KeyValuePair<string, object> item) {
			return _local.Remove(item);
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator() {
			return _local.GetEnumerator(); ;
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return _local.GetEnumerator();
		}

		private static bool _registered = false;
		public static void RegisterMergeVarFieldValuesJsonConversion() {
			if (_registered) {
				return;
			}
			_registered = true;
			JsConfig<MergeVar>.RawSerializeFn = x => {
				var dict = x.ToDictionary(a => a.Key, b=> b.Value);
				foreach (System.Reflection.PropertyInfo item in x.GetType().GetSerializableProperties()) {
					switch (item.Name) {
						case "Keys":
						case "Count":
						case "Values":
						case "IsReadOnly":
							continue;
						default:
							break;
					}
					object val = item.GetValue(x, null);
					if (val == null) {
						continue;
					}
					string name = item.Name;
					DataMemberAttribute dataMember = item.GetDataMember();
					if (dataMember != null) {
						name = dataMember.Name;
					}
					dict[name] = val;
				}
				return dict.ToJson();
			};
			JsConfig<MergeVar>.RawDeserializeFn = x => {
				return JsonObject.Parse(x).ConvertTo<MergeVar>( y => {
					MergeVar result = new MergeVar();
					foreach (KeyValuePair<string, string> item in y) {
						switch (item.Key.ToLowerInvariant()) {
							case "groupings":
								result.Groupings = y.Get<List<Grouping>>(item.Key);
								break;
							case "mc_language":
								result.Language = y.Get(item.Key);
								break;
							case "mc_location":
								result.LocationData = y.Get<MCLocation>(item.Key);
								break;
							case "new-email":
								result.NewEmail = y.Get(item.Key);
								break;
							case "mc_notes-email":
								result.Notes = y.Get<List<MCNote>>(item.Key);
								break;
							case "optin_ip":
								result.OptInIP = y.Get(item.Key);
								break;
							case "optin_time":
								result.OptInTime = y.Get(item.Key);
								break;
							case "email":
								// skip
								break;
							default:
								result.Add(item.Key, y.Get<object>(item.Key));
								break;
						}
					}
					return result;
				});
			};
		}


    }
}
