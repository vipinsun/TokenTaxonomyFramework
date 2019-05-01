// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: core.proto

package org.tti.tokens.model.core;

public interface BehaviorGroupOrBuilder extends
    // @@protoc_insertion_point(interface_extends:taxonomy.model.core.BehaviorGroup)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <code>.taxonomy.model.artifact.Artifact artifact = 1;</code>
   */
  boolean hasArtifact();
  /**
   * <code>.taxonomy.model.artifact.Artifact artifact = 1;</code>
   */
  org.tti.tokens.model.artifact.Artifact getArtifact();
  /**
   * <code>.taxonomy.model.artifact.Artifact artifact = 1;</code>
   */
  org.tti.tokens.model.artifact.ArtifactOrBuilder getArtifactOrBuilder();

  /**
   * <code>repeated .taxonomy.model.artifact.ArtifactSymbol behavior_symbols = 2;</code>
   */
  java.util.List<org.tti.tokens.model.artifact.ArtifactSymbol> 
      getBehaviorSymbolsList();
  /**
   * <code>repeated .taxonomy.model.artifact.ArtifactSymbol behavior_symbols = 2;</code>
   */
  org.tti.tokens.model.artifact.ArtifactSymbol getBehaviorSymbols(int index);
  /**
   * <code>repeated .taxonomy.model.artifact.ArtifactSymbol behavior_symbols = 2;</code>
   */
  int getBehaviorSymbolsCount();
  /**
   * <code>repeated .taxonomy.model.artifact.ArtifactSymbol behavior_symbols = 2;</code>
   */
  java.util.List<? extends org.tti.tokens.model.artifact.ArtifactSymbolOrBuilder> 
      getBehaviorSymbolsOrBuilderList();
  /**
   * <code>repeated .taxonomy.model.artifact.ArtifactSymbol behavior_symbols = 2;</code>
   */
  org.tti.tokens.model.artifact.ArtifactSymbolOrBuilder getBehaviorSymbolsOrBuilder(
      int index);

  /**
   * <pre>
   *if retrieved this can be populated with the behaviors nested in the group.
   * </pre>
   *
   * <code>map&lt;string, .taxonomy.model.artifact.Artifact&gt; member_behavior_artifacts = 3;</code>
   */
  int getMemberBehaviorArtifactsCount();
  /**
   * <pre>
   *if retrieved this can be populated with the behaviors nested in the group.
   * </pre>
   *
   * <code>map&lt;string, .taxonomy.model.artifact.Artifact&gt; member_behavior_artifacts = 3;</code>
   */
  boolean containsMemberBehaviorArtifacts(
      java.lang.String key);
  /**
   * Use {@link #getMemberBehaviorArtifactsMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.String, org.tti.tokens.model.artifact.Artifact>
  getMemberBehaviorArtifacts();
  /**
   * <pre>
   *if retrieved this can be populated with the behaviors nested in the group.
   * </pre>
   *
   * <code>map&lt;string, .taxonomy.model.artifact.Artifact&gt; member_behavior_artifacts = 3;</code>
   */
  java.util.Map<java.lang.String, org.tti.tokens.model.artifact.Artifact>
  getMemberBehaviorArtifactsMap();
  /**
   * <pre>
   *if retrieved this can be populated with the behaviors nested in the group.
   * </pre>
   *
   * <code>map&lt;string, .taxonomy.model.artifact.Artifact&gt; member_behavior_artifacts = 3;</code>
   */

  org.tti.tokens.model.artifact.Artifact getMemberBehaviorArtifactsOrDefault(
      java.lang.String key,
      org.tti.tokens.model.artifact.Artifact defaultValue);
  /**
   * <pre>
   *if retrieved this can be populated with the behaviors nested in the group.
   * </pre>
   *
   * <code>map&lt;string, .taxonomy.model.artifact.Artifact&gt; member_behavior_artifacts = 3;</code>
   */

  org.tti.tokens.model.artifact.Artifact getMemberBehaviorArtifactsOrThrow(
      java.lang.String key);
}
